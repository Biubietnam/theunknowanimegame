using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000471 RID: 1137
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSummonActivityStageScRsp : IMessage<EnterSummonActivityStageScRsp>, IMessage, IEquatable<EnterSummonActivityStageScRsp>, IDeepCloneable<EnterSummonActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x060032A3 RID: 12963 RVA: 0x0008B603 File Offset: 0x00089803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSummonActivityStageScRsp> Parser
		{
			get
			{
				return EnterSummonActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x0008B60A File Offset: 0x0008980A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSummonActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x060032A5 RID: 12965 RVA: 0x0008B61C File Offset: 0x0008981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSummonActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x0008B623 File Offset: 0x00089823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSummonActivityStageScRsp()
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x0008B62C File Offset: 0x0008982C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSummonActivityStageScRsp(EnterSummonActivityStageScRsp other) : this()
		{
			this.groupId_ = other.groupId_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0008B690 File Offset: 0x00089890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSummonActivityStageScRsp Clone()
		{
			return new EnterSummonActivityStageScRsp(this);
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x0008B698 File Offset: 0x00089898
		// (set) Token: 0x060032AA RID: 12970 RVA: 0x0008B6A0 File Offset: 0x000898A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x0008B6A9 File Offset: 0x000898A9
		// (set) Token: 0x060032AC RID: 12972 RVA: 0x0008B6B1 File Offset: 0x000898B1
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x0008B6BA File Offset: 0x000898BA
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x0008B6C2 File Offset: 0x000898C2
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

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x0008B6CB File Offset: 0x000898CB
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x0008B6D3 File Offset: 0x000898D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x0008B6DC File Offset: 0x000898DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSummonActivityStageScRsp);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x0008B6EC File Offset: 0x000898EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSummonActivityStageScRsp other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && this.AHFNGPLDAII == other.AHFNGPLDAII && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0008B75C File Offset: 0x0008995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0008B7E3 File Offset: 0x000899E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0008B7EB File Offset: 0x000899EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x0008B7F4 File Offset: 0x000899F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GroupId);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x0008B888 File Offset: 0x00089A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0008B910 File Offset: 0x00089B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSummonActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
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
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x0008B9A0 File Offset: 0x00089BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x0008B9AC File Offset: 0x00089BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 18U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.AHFNGPLDAII = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400142D RID: 5165
		private static readonly MessageParser<EnterSummonActivityStageScRsp> _parser = new MessageParser<EnterSummonActivityStageScRsp>(() => new EnterSummonActivityStageScRsp());

		// Token: 0x0400142E RID: 5166
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400142F RID: 5167
		public const int GroupIdFieldNumber = 11;

		// Token: 0x04001430 RID: 5168
		private uint groupId_;

		// Token: 0x04001431 RID: 5169
		public const int BattleInfoFieldNumber = 2;

		// Token: 0x04001432 RID: 5170
		private SceneBattleInfo battleInfo_;

		// Token: 0x04001433 RID: 5171
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001434 RID: 5172
		private uint retcode_;

		// Token: 0x04001435 RID: 5173
		public const int AHFNGPLDAIIFieldNumber = 12;

		// Token: 0x04001436 RID: 5174
		private uint aHFNGPLDAII_;
	}
}
