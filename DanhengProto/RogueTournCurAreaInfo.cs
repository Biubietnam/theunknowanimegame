using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F8B RID: 3979
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournCurAreaInfo : IMessage<RogueTournCurAreaInfo>, IMessage, IEquatable<RogueTournCurAreaInfo>, IDeepCloneable<RogueTournCurAreaInfo>, IBufferMessage
	{
		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600B135 RID: 45365 RVA: 0x001DC167 File Offset: 0x001DA367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournCurAreaInfo> Parser
		{
			get
			{
				return RogueTournCurAreaInfo._parser;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600B136 RID: 45366 RVA: 0x001DC16E File Offset: 0x001DA36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournCurAreaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600B137 RID: 45367 RVA: 0x001DC180 File Offset: 0x001DA380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournCurAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x001DC187 File Offset: 0x001DA387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurAreaInfo()
		{
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x001DC190 File Offset: 0x001DA390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurAreaInfo(RogueTournCurAreaInfo other) : this()
		{
			this.rogueMagicBattleConst_ = other.rogueMagicBattleConst_;
			this.subAreaId_ = other.subAreaId_;
			this.iHKHNEGBELE_ = other.iHKHNEGBELE_;
			this.rogueSubMode_ = other.rogueSubMode_;
			this.pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x001DC200 File Offset: 0x001DA400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurAreaInfo Clone()
		{
			return new RogueTournCurAreaInfo(this);
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600B13B RID: 45371 RVA: 0x001DC208 File Offset: 0x001DA408
		// (set) Token: 0x0600B13C RID: 45372 RVA: 0x001DC210 File Offset: 0x001DA410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueMagicBattleConst
		{
			get
			{
				return this.rogueMagicBattleConst_;
			}
			set
			{
				this.rogueMagicBattleConst_ = value;
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600B13D RID: 45373 RVA: 0x001DC219 File Offset: 0x001DA419
		// (set) Token: 0x0600B13E RID: 45374 RVA: 0x001DC221 File Offset: 0x001DA421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubAreaId
		{
			get
			{
				return this.subAreaId_;
			}
			set
			{
				this.subAreaId_ = value;
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600B13F RID: 45375 RVA: 0x001DC22A File Offset: 0x001DA42A
		// (set) Token: 0x0600B140 RID: 45376 RVA: 0x001DC232 File Offset: 0x001DA432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IHKHNEGBELE
		{
			get
			{
				return this.iHKHNEGBELE_;
			}
			set
			{
				this.iHKHNEGBELE_ = value;
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600B141 RID: 45377 RVA: 0x001DC23B File Offset: 0x001DA43B
		// (set) Token: 0x0600B142 RID: 45378 RVA: 0x001DC243 File Offset: 0x001DA443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueSubMode
		{
			get
			{
				return this.rogueSubMode_;
			}
			set
			{
				this.rogueSubMode_ = value;
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600B143 RID: 45379 RVA: 0x001DC24C File Offset: 0x001DA44C
		// (set) Token: 0x0600B144 RID: 45380 RVA: 0x001DC254 File Offset: 0x001DA454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction PendingAction
		{
			get
			{
				return this.pendingAction_;
			}
			set
			{
				this.pendingAction_ = value;
			}
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x001DC25D File Offset: 0x001DA45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournCurAreaInfo);
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x001DC26C File Offset: 0x001DA46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournCurAreaInfo other)
		{
			return other != null && (other == this || (this.RogueMagicBattleConst == other.RogueMagicBattleConst && this.SubAreaId == other.SubAreaId && this.IHKHNEGBELE == other.IHKHNEGBELE && this.RogueSubMode == other.RogueSubMode && object.Equals(this.PendingAction, other.PendingAction) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x001DC2EC File Offset: 0x001DA4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueMagicBattleConst != 0U)
			{
				num ^= this.RogueMagicBattleConst.GetHashCode();
			}
			if (this.SubAreaId != 0U)
			{
				num ^= this.SubAreaId.GetHashCode();
			}
			if (this.IHKHNEGBELE != 0U)
			{
				num ^= this.IHKHNEGBELE.GetHashCode();
			}
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			if (this.pendingAction_ != null)
			{
				num ^= this.PendingAction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x001DC38C File Offset: 0x001DA58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x001DC394 File Offset: 0x001DA594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x001DC3A0 File Offset: 0x001DA5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RogueMagicBattleConst != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RogueMagicBattleConst);
			}
			if (this.pendingAction_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PendingAction);
			}
			if (this.IHKHNEGBELE != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.IHKHNEGBELE);
			}
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this.SubAreaId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SubAreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x001DC44C File Offset: 0x001DA64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueMagicBattleConst != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueMagicBattleConst);
			}
			if (this.SubAreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubAreaId);
			}
			if (this.IHKHNEGBELE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IHKHNEGBELE);
			}
			if (this.RogueSubMode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			if (this.pendingAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PendingAction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x001DC4EC File Offset: 0x001DA6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournCurAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueMagicBattleConst != 0U)
			{
				this.RogueMagicBattleConst = other.RogueMagicBattleConst;
			}
			if (other.SubAreaId != 0U)
			{
				this.SubAreaId = other.SubAreaId;
			}
			if (other.IHKHNEGBELE != 0U)
			{
				this.IHKHNEGBELE = other.IHKHNEGBELE;
			}
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			if (other.pendingAction_ != null)
			{
				if (this.pendingAction_ == null)
				{
					this.PendingAction = new RogueCommonPendingAction();
				}
				this.PendingAction.MergeFrom(other.PendingAction);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x001DC590 File Offset: 0x001DA790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x001DC59C File Offset: 0x001DA79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.RogueMagicBattleConst = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.pendingAction_ == null)
						{
							this.PendingAction = new RogueCommonPendingAction();
						}
						input.ReadMessage(this.PendingAction);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.IHKHNEGBELE = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RogueSubMode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.SubAreaId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004816 RID: 18454
		private static readonly MessageParser<RogueTournCurAreaInfo> _parser = new MessageParser<RogueTournCurAreaInfo>(() => new RogueTournCurAreaInfo());

		// Token: 0x04004817 RID: 18455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004818 RID: 18456
		public const int RogueMagicBattleConstFieldNumber = 1;

		// Token: 0x04004819 RID: 18457
		private uint rogueMagicBattleConst_;

		// Token: 0x0400481A RID: 18458
		public const int SubAreaIdFieldNumber = 12;

		// Token: 0x0400481B RID: 18459
		private uint subAreaId_;

		// Token: 0x0400481C RID: 18460
		public const int IHKHNEGBELEFieldNumber = 5;

		// Token: 0x0400481D RID: 18461
		private uint iHKHNEGBELE_;

		// Token: 0x0400481E RID: 18462
		public const int RogueSubModeFieldNumber = 8;

		// Token: 0x0400481F RID: 18463
		private uint rogueSubMode_;

		// Token: 0x04004820 RID: 18464
		public const int PendingActionFieldNumber = 4;

		// Token: 0x04004821 RID: 18465
		private RogueCommonPendingAction pendingAction_;
	}
}
