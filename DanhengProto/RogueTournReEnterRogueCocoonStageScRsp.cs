using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FFF RID: 4095
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournReEnterRogueCocoonStageScRsp : IMessage<RogueTournReEnterRogueCocoonStageScRsp>, IMessage, IEquatable<RogueTournReEnterRogueCocoonStageScRsp>, IDeepCloneable<RogueTournReEnterRogueCocoonStageScRsp>, IBufferMessage
	{
		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600B633 RID: 46643 RVA: 0x001E8F27 File Offset: 0x001E7127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournReEnterRogueCocoonStageScRsp> Parser
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageScRsp._parser;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600B634 RID: 46644 RVA: 0x001E8F2E File Offset: 0x001E712E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x001E8F40 File Offset: 0x001E7140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600B636 RID: 46646 RVA: 0x001E8F47 File Offset: 0x001E7147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReEnterRogueCocoonStageScRsp()
		{
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x001E8F50 File Offset: 0x001E7150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReEnterRogueCocoonStageScRsp(RogueTournReEnterRogueCocoonStageScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B638 RID: 46648 RVA: 0x001E8F9C File Offset: 0x001E719C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReEnterRogueCocoonStageScRsp Clone()
		{
			return new RogueTournReEnterRogueCocoonStageScRsp(this);
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600B639 RID: 46649 RVA: 0x001E8FA4 File Offset: 0x001E71A4
		// (set) Token: 0x0600B63A RID: 46650 RVA: 0x001E8FAC File Offset: 0x001E71AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600B63B RID: 46651 RVA: 0x001E8FB5 File Offset: 0x001E71B5
		// (set) Token: 0x0600B63C RID: 46652 RVA: 0x001E8FBD File Offset: 0x001E71BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x001E8FC6 File Offset: 0x001E71C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournReEnterRogueCocoonStageScRsp);
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x001E8FD4 File Offset: 0x001E71D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournReEnterRogueCocoonStageScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x001E9024 File Offset: 0x001E7224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x001E9079 File Offset: 0x001E7279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x001E9081 File Offset: 0x001E7281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x001E908C File Offset: 0x001E728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x001E90E8 File Offset: 0x001E72E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x001E9140 File Offset: 0x001E7340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournReEnterRogueCocoonStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x001E91A8 File Offset: 0x001E73A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B646 RID: 46662 RVA: 0x001E91B4 File Offset: 0x001E73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x040049DB RID: 18907
		private static readonly MessageParser<RogueTournReEnterRogueCocoonStageScRsp> _parser = new MessageParser<RogueTournReEnterRogueCocoonStageScRsp>(() => new RogueTournReEnterRogueCocoonStageScRsp());

		// Token: 0x040049DC RID: 18908
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049DD RID: 18909
		public const int BattleInfoFieldNumber = 12;

		// Token: 0x040049DE RID: 18910
		private SceneBattleInfo battleInfo_;

		// Token: 0x040049DF RID: 18911
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040049E0 RID: 18912
		private uint retcode_;
	}
}
