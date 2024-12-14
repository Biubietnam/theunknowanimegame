using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200000B RID: 11
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ABNNODDPNDM : IMessage<ABNNODDPNDM>, IMessage, IEquatable<ABNNODDPNDM>, IDeepCloneable<ABNNODDPNDM>, IBufferMessage
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002954 File Offset: 0x00000B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ABNNODDPNDM> Parser
		{
			get
			{
				return ABNNODDPNDM._parser;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000295B File Offset: 0x00000B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ABNNODDPNDMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000296D File Offset: 0x00000B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ABNNODDPNDM.Descriptor;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002974 File Offset: 0x00000B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ABNNODDPNDM()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000297C File Offset: 0x00000B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ABNNODDPNDM(ABNNODDPNDM other) : this()
		{
			this.dCHJNNNJCGF_ = other.dCHJNNNJCGF_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000029AD File Offset: 0x00000BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ABNNODDPNDM Clone()
		{
			return new ABNNODDPNDM(this);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000029B5 File Offset: 0x00000BB5
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000029BD File Offset: 0x00000BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DCHJNNNJCGF
		{
			get
			{
				return this.dCHJNNNJCGF_;
			}
			set
			{
				this.dCHJNNNJCGF_ = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000029C6 File Offset: 0x00000BC6
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000029CE File Offset: 0x00000BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000029D7 File Offset: 0x00000BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ABNNODDPNDM);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000029E5 File Offset: 0x00000BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ABNNODDPNDM other)
		{
			return other != null && (other == this || (this.DCHJNNNJCGF == other.DCHJNNNJCGF && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002A24 File Offset: 0x00000C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DCHJNNNJCGF != 0U)
			{
				num ^= this.DCHJNNNJCGF.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002A7C File Offset: 0x00000C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002A84 File Offset: 0x00000C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002A90 File Offset: 0x00000C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DCHJNNNJCGF != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DCHJNNNJCGF);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002AEC File Offset: 0x00000CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DCHJNNNJCGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DCHJNNNJCGF);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002B38 File Offset: 0x00000D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ABNNODDPNDM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DCHJNNNJCGF != 0U)
			{
				this.DCHJNNNJCGF = other.DCHJNNNJCGF;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002B88 File Offset: 0x00000D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B94 File Offset: 0x00000D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsFinish = input.ReadBool();
					}
				}
				else
				{
					this.DCHJNNNJCGF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly MessageParser<ABNNODDPNDM> _parser = new MessageParser<ABNNODDPNDM>(() => new ABNNODDPNDM());

		// Token: 0x04000021 RID: 33
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000022 RID: 34
		public const int DCHJNNNJCGFFieldNumber = 5;

		// Token: 0x04000023 RID: 35
		private uint dCHJNNNJCGF_;

		// Token: 0x04000024 RID: 36
		public const int IsFinishFieldNumber = 10;

		// Token: 0x04000025 RID: 37
		private bool isFinish_;
	}
}
