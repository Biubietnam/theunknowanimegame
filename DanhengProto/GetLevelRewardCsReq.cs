using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F1 RID: 1777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLevelRewardCsReq : IMessage<GetLevelRewardCsReq>, IMessage, IEquatable<GetLevelRewardCsReq>, IDeepCloneable<GetLevelRewardCsReq>, IBufferMessage
	{
		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x000D6A55 File Offset: 0x000D4C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLevelRewardCsReq> Parser
		{
			get
			{
				return GetLevelRewardCsReq._parser;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x000D6A5C File Offset: 0x000D4C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x000D6A6E File Offset: 0x000D4C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelRewardCsReq.Descriptor;
			}
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x000D6A75 File Offset: 0x000D4C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardCsReq()
		{
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x000D6A7D File Offset: 0x000D4C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardCsReq(GetLevelRewardCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x000D6AAE File Offset: 0x000D4CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardCsReq Clone()
		{
			return new GetLevelRewardCsReq(this);
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06004F7C RID: 20348 RVA: 0x000D6AB6 File Offset: 0x000D4CB6
		// (set) Token: 0x06004F7D RID: 20349 RVA: 0x000D6ABE File Offset: 0x000D4CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x000D6AC7 File Offset: 0x000D4CC7
		// (set) Token: 0x06004F7F RID: 20351 RVA: 0x000D6ACF File Offset: 0x000D4CCF
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

		// Token: 0x06004F80 RID: 20352 RVA: 0x000D6AD8 File Offset: 0x000D4CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelRewardCsReq);
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x000D6AE6 File Offset: 0x000D4CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelRewardCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x000D6B24 File Offset: 0x000D4D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x000D6B7C File Offset: 0x000D4D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x000D6B84 File Offset: 0x000D4D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x000D6B90 File Offset: 0x000D4D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x000D6BEC File Offset: 0x000D4DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x000D6C44 File Offset: 0x000D4E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x000D6C94 File Offset: 0x000D4E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x000D6CA0 File Offset: 0x000D4EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractedPropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F54 RID: 8020
		private static readonly MessageParser<GetLevelRewardCsReq> _parser = new MessageParser<GetLevelRewardCsReq>(() => new GetLevelRewardCsReq());

		// Token: 0x04001F55 RID: 8021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F56 RID: 8022
		public const int InteractedPropEntityIdFieldNumber = 7;

		// Token: 0x04001F57 RID: 8023
		private uint interactedPropEntityId_;

		// Token: 0x04001F58 RID: 8024
		public const int LevelFieldNumber = 3;

		// Token: 0x04001F59 RID: 8025
		private uint level_;
	}
}
