using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D2D RID: 3373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordMonsterKey : IMessage<PunkLordMonsterKey>, IMessage, IEquatable<PunkLordMonsterKey>, IDeepCloneable<PunkLordMonsterKey>, IBufferMessage
	{
		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x060096A8 RID: 38568 RVA: 0x00190F58 File Offset: 0x0018F158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordMonsterKey> Parser
		{
			get
			{
				return PunkLordMonsterKey._parser;
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x060096A9 RID: 38569 RVA: 0x00190F5F File Offset: 0x0018F15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterKeyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x060096AA RID: 38570 RVA: 0x00190F71 File Offset: 0x0018F171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordMonsterKey.Descriptor;
			}
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00190F78 File Offset: 0x0018F178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKey()
		{
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x00190F80 File Offset: 0x0018F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKey(PunkLordMonsterKey other) : this()
		{
			this.uid_ = other.uid_;
			this.monsterId_ = other.monsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x00190FB1 File Offset: 0x0018F1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKey Clone()
		{
			return new PunkLordMonsterKey(this);
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x00190FB9 File Offset: 0x0018F1B9
		// (set) Token: 0x060096AF RID: 38575 RVA: 0x00190FC1 File Offset: 0x0018F1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x060096B0 RID: 38576 RVA: 0x00190FCA File Offset: 0x0018F1CA
		// (set) Token: 0x060096B1 RID: 38577 RVA: 0x00190FD2 File Offset: 0x0018F1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x060096B2 RID: 38578 RVA: 0x00190FDB File Offset: 0x0018F1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordMonsterKey);
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x00190FE9 File Offset: 0x0018F1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordMonsterKey other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.MonsterId == other.MonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x00191028 File Offset: 0x0018F228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x00191080 File Offset: 0x0018F280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060096B6 RID: 38582 RVA: 0x00191088 File Offset: 0x0018F288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096B7 RID: 38583 RVA: 0x00191094 File Offset: 0x0018F294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096B8 RID: 38584 RVA: 0x001910EC File Offset: 0x0018F2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x00191144 File Offset: 0x0018F344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordMonsterKey other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x00191194 File Offset: 0x0018F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x001911A0 File Offset: 0x0018F3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MonsterId = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003A7B RID: 14971
		private static readonly MessageParser<PunkLordMonsterKey> _parser = new MessageParser<PunkLordMonsterKey>(() => new PunkLordMonsterKey());

		// Token: 0x04003A7C RID: 14972
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A7D RID: 14973
		public const int UidFieldNumber = 1;

		// Token: 0x04003A7E RID: 14974
		private uint uid_;

		// Token: 0x04003A7F RID: 14975
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04003A80 RID: 14976
		private uint monsterId_;
	}
}
