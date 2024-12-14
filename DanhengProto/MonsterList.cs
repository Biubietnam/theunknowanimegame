using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B8F RID: 2959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterList : IMessage<MonsterList>, IMessage, IEquatable<MonsterList>, IDeepCloneable<MonsterList>, IBufferMessage
	{
		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x0015A02C File Offset: 0x0015822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterList> Parser
		{
			get
			{
				return MonsterList._parser;
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x0015A033 File Offset: 0x00158233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonsterListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x06008318 RID: 33560 RVA: 0x0015A045 File Offset: 0x00158245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterList.Descriptor;
			}
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0015A04C File Offset: 0x0015824C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterList()
		{
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x0015A054 File Offset: 0x00158254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterList(MonsterList other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x0015A085 File Offset: 0x00158285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterList Clone()
		{
			return new MonsterList(this);
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600831C RID: 33564 RVA: 0x0015A08D File Offset: 0x0015828D
		// (set) Token: 0x0600831D RID: 33565 RVA: 0x0015A095 File Offset: 0x00158295
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

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600831E RID: 33566 RVA: 0x0015A09E File Offset: 0x0015829E
		// (set) Token: 0x0600831F RID: 33567 RVA: 0x0015A0A6 File Offset: 0x001582A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x0015A0AF File Offset: 0x001582AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterList);
		}

		// Token: 0x06008321 RID: 33569 RVA: 0x0015A0BD File Offset: 0x001582BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterList other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008322 RID: 33570 RVA: 0x0015A0FC File Offset: 0x001582FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x0015A154 File Offset: 0x00158354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x0015A15C File Offset: 0x0015835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x0015A168 File Offset: 0x00158368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x0015A1C4 File Offset: 0x001583C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x0015A21C File Offset: 0x0015841C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x0015A26C File Offset: 0x0015846C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x0015A278 File Offset: 0x00158478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.MonsterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003224 RID: 12836
		private static readonly MessageParser<MonsterList> _parser = new MessageParser<MonsterList>(() => new MonsterList());

		// Token: 0x04003225 RID: 12837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003226 RID: 12838
		public const int MonsterIdFieldNumber = 10;

		// Token: 0x04003227 RID: 12839
		private uint monsterId_;

		// Token: 0x04003228 RID: 12840
		public const int NumFieldNumber = 14;

		// Token: 0x04003229 RID: 12841
		private uint num_;
	}
}
