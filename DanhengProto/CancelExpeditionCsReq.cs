using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000163 RID: 355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelExpeditionCsReq : IMessage<CancelExpeditionCsReq>, IMessage, IEquatable<CancelExpeditionCsReq>, IDeepCloneable<CancelExpeditionCsReq>, IBufferMessage
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0002E494 File Offset: 0x0002C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelExpeditionCsReq> Parser
		{
			get
			{
				return CancelExpeditionCsReq._parser;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0002E49B File Offset: 0x0002C69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelExpeditionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0002E4AD File Offset: 0x0002C6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelExpeditionCsReq.Descriptor;
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelExpeditionCsReq()
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0002E4BC File Offset: 0x0002C6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelExpeditionCsReq(CancelExpeditionCsReq other) : this()
		{
			this.gLIEPFENPHH_ = other.gLIEPFENPHH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0002E4E1 File Offset: 0x0002C6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelExpeditionCsReq Clone()
		{
			return new CancelExpeditionCsReq(this);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0002E4E9 File Offset: 0x0002C6E9
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0002E4F1 File Offset: 0x0002C6F1
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

		// Token: 0x06000FDF RID: 4063 RVA: 0x0002E4FA File Offset: 0x0002C6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelExpeditionCsReq);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0002E508 File Offset: 0x0002C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelExpeditionCsReq other)
		{
			return other != null && (other == this || (this.GLIEPFENPHH == other.GLIEPFENPHH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0002E538 File Offset: 0x0002C738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GLIEPFENPHH != 0U)
			{
				num ^= this.GLIEPFENPHH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0002E577 File Offset: 0x0002C777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0002E57F File Offset: 0x0002C77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0002E588 File Offset: 0x0002C788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GLIEPFENPHH != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GLIEPFENPHH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GLIEPFENPHH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GLIEPFENPHH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0002E5FA File Offset: 0x0002C7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelExpeditionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GLIEPFENPHH != 0U)
			{
				this.GLIEPFENPHH = other.GLIEPFENPHH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0002E62B File Offset: 0x0002C82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0002E634 File Offset: 0x0002C834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GLIEPFENPHH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006BD RID: 1725
		private static readonly MessageParser<CancelExpeditionCsReq> _parser = new MessageParser<CancelExpeditionCsReq>(() => new CancelExpeditionCsReq());

		// Token: 0x040006BE RID: 1726
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006BF RID: 1727
		public const int GLIEPFENPHHFieldNumber = 15;

		// Token: 0x040006C0 RID: 1728
		private uint gLIEPFENPHH_;
	}
}
