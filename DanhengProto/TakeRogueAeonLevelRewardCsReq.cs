using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200131D RID: 4893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueAeonLevelRewardCsReq : IMessage<TakeRogueAeonLevelRewardCsReq>, IMessage, IEquatable<TakeRogueAeonLevelRewardCsReq>, IDeepCloneable<TakeRogueAeonLevelRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600DA4E RID: 55886 RVA: 0x0024584D File Offset: 0x00243A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueAeonLevelRewardCsReq> Parser
		{
			get
			{
				return TakeRogueAeonLevelRewardCsReq._parser;
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600DA4F RID: 55887 RVA: 0x00245854 File Offset: 0x00243A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueAeonLevelRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600DA50 RID: 55888 RVA: 0x00245866 File Offset: 0x00243A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueAeonLevelRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DA51 RID: 55889 RVA: 0x0024586D File Offset: 0x00243A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueAeonLevelRewardCsReq()
		{
		}

		// Token: 0x0600DA52 RID: 55890 RVA: 0x00245875 File Offset: 0x00243A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueAeonLevelRewardCsReq(TakeRogueAeonLevelRewardCsReq other) : this()
		{
			this.level_ = other.level_;
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA53 RID: 55891 RVA: 0x002458A6 File Offset: 0x00243AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueAeonLevelRewardCsReq Clone()
		{
			return new TakeRogueAeonLevelRewardCsReq(this);
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x002458AE File Offset: 0x00243AAE
		// (set) Token: 0x0600DA55 RID: 55893 RVA: 0x002458B6 File Offset: 0x00243AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600DA56 RID: 55894 RVA: 0x002458BF File Offset: 0x00243ABF
		// (set) Token: 0x0600DA57 RID: 55895 RVA: 0x002458C7 File Offset: 0x00243AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x0600DA58 RID: 55896 RVA: 0x002458D0 File Offset: 0x00243AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueAeonLevelRewardCsReq);
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x002458DE File Offset: 0x00243ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueAeonLevelRewardCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x0024591C File Offset: 0x00243B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA5B RID: 55899 RVA: 0x00245974 File Offset: 0x00243B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA5C RID: 55900 RVA: 0x0024597C File Offset: 0x00243B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x00245988 File Offset: 0x00243B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Level);
			}
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA5E RID: 55902 RVA: 0x002459E4 File Offset: 0x00243BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA5F RID: 55903 RVA: 0x00245A3C File Offset: 0x00243C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueAeonLevelRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x00245A8C File Offset: 0x00243C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA61 RID: 55905 RVA: 0x00245A98 File Offset: 0x00243C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AeonId = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040056F2 RID: 22258
		private static readonly MessageParser<TakeRogueAeonLevelRewardCsReq> _parser = new MessageParser<TakeRogueAeonLevelRewardCsReq>(() => new TakeRogueAeonLevelRewardCsReq());

		// Token: 0x040056F3 RID: 22259
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056F4 RID: 22260
		public const int LevelFieldNumber = 8;

		// Token: 0x040056F5 RID: 22261
		private uint level_;

		// Token: 0x040056F6 RID: 22262
		public const int AeonIdFieldNumber = 14;

		// Token: 0x040056F7 RID: 22263
		private uint aeonId_;
	}
}
