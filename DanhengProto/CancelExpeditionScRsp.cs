using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000165 RID: 357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelExpeditionScRsp : IMessage<CancelExpeditionScRsp>, IMessage, IEquatable<CancelExpeditionScRsp>, IDeepCloneable<CancelExpeditionScRsp>, IBufferMessage
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0002E70C File Offset: 0x0002C90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelExpeditionScRsp> Parser
		{
			get
			{
				return CancelExpeditionScRsp._parser;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x0002E713 File Offset: 0x0002C913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelExpeditionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0002E725 File Offset: 0x0002C925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelExpeditionScRsp.Descriptor;
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0002E72C File Offset: 0x0002C92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelExpeditionScRsp()
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0002E734 File Offset: 0x0002C934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelExpeditionScRsp(CancelExpeditionScRsp other) : this()
		{
			this.gLIEPFENPHH_ = other.gLIEPFENPHH_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0002E765 File Offset: 0x0002C965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelExpeditionScRsp Clone()
		{
			return new CancelExpeditionScRsp(this);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0002E76D File Offset: 0x0002C96D
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0002E775 File Offset: 0x0002C975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GLIEPFENPHH
		{
			get
			{
				return this.gLIEPFENPHH_;
			}
			set
			{
				this.gLIEPFENPHH_ = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0002E77E File Offset: 0x0002C97E
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0002E786 File Offset: 0x0002C986
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

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0002E78F File Offset: 0x0002C98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelExpeditionScRsp);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0002E79D File Offset: 0x0002C99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelExpeditionScRsp other)
		{
			return other != null && (other == this || (this.GLIEPFENPHH == other.GLIEPFENPHH && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0002E7DC File Offset: 0x0002C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GLIEPFENPHH != 0U)
			{
				num ^= this.GLIEPFENPHH.GetHashCode();
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

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0002E834 File Offset: 0x0002CA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0002E83C File Offset: 0x0002CA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0002E848 File Offset: 0x0002CA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GLIEPFENPHH != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GLIEPFENPHH);
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

		// Token: 0x06000FFC RID: 4092 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GLIEPFENPHH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GLIEPFENPHH);
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

		// Token: 0x06000FFD RID: 4093 RVA: 0x0002E8FC File Offset: 0x0002CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelExpeditionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GLIEPFENPHH != 0U)
			{
				this.GLIEPFENPHH = other.GLIEPFENPHH;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0002E958 File Offset: 0x0002CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
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
					this.GLIEPFENPHH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006C2 RID: 1730
		private static readonly MessageParser<CancelExpeditionScRsp> _parser = new MessageParser<CancelExpeditionScRsp>(() => new CancelExpeditionScRsp());

		// Token: 0x040006C3 RID: 1731
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006C4 RID: 1732
		public const int GLIEPFENPHHFieldNumber = 7;

		// Token: 0x040006C5 RID: 1733
		private uint gLIEPFENPHH_;

		// Token: 0x040006C6 RID: 1734
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040006C7 RID: 1735
		private uint retcode_;
	}
}
