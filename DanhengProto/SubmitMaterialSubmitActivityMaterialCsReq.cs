using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011FB RID: 4603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitMaterialSubmitActivityMaterialCsReq : IMessage<SubmitMaterialSubmitActivityMaterialCsReq>, IMessage, IEquatable<SubmitMaterialSubmitActivityMaterialCsReq>, IDeepCloneable<SubmitMaterialSubmitActivityMaterialCsReq>, IBufferMessage
	{
		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x002282A9 File Offset: 0x002264A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitMaterialSubmitActivityMaterialCsReq> Parser
		{
			get
			{
				return SubmitMaterialSubmitActivityMaterialCsReq._parser;
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600CDBE RID: 52670 RVA: 0x002282B0 File Offset: 0x002264B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitMaterialSubmitActivityMaterialCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600CDBF RID: 52671 RVA: 0x002282C2 File Offset: 0x002264C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitMaterialSubmitActivityMaterialCsReq.Descriptor;
			}
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x002282C9 File Offset: 0x002264C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitMaterialSubmitActivityMaterialCsReq()
		{
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x002282D1 File Offset: 0x002264D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitMaterialSubmitActivityMaterialCsReq(SubmitMaterialSubmitActivityMaterialCsReq other) : this()
		{
			this.nCEJNFFMGGF_ = other.nCEJNFFMGGF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x002282F6 File Offset: 0x002264F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitMaterialSubmitActivityMaterialCsReq Clone()
		{
			return new SubmitMaterialSubmitActivityMaterialCsReq(this);
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600CDC3 RID: 52675 RVA: 0x002282FE File Offset: 0x002264FE
		// (set) Token: 0x0600CDC4 RID: 52676 RVA: 0x00228306 File Offset: 0x00226506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCEJNFFMGGF
		{
			get
			{
				return this.nCEJNFFMGGF_;
			}
			set
			{
				this.nCEJNFFMGGF_ = value;
			}
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x0022830F File Offset: 0x0022650F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitMaterialSubmitActivityMaterialCsReq);
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x0022831D File Offset: 0x0022651D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitMaterialSubmitActivityMaterialCsReq other)
		{
			return other != null && (other == this || (this.NCEJNFFMGGF == other.NCEJNFFMGGF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x0022834C File Offset: 0x0022654C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCEJNFFMGGF != 0U)
			{
				num ^= this.NCEJNFFMGGF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x0022838B File Offset: 0x0022658B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x00228393 File Offset: 0x00226593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x0022839C File Offset: 0x0022659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCEJNFFMGGF != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.NCEJNFFMGGF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDCB RID: 52683 RVA: 0x002283D0 File Offset: 0x002265D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCEJNFFMGGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCEJNFFMGGF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x0022840E File Offset: 0x0022660E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitMaterialSubmitActivityMaterialCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCEJNFFMGGF != 0U)
			{
				this.NCEJNFFMGGF = other.NCEJNFFMGGF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x0022843F File Offset: 0x0022663F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x00228448 File Offset: 0x00226648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NCEJNFFMGGF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040052F3 RID: 21235
		private static readonly MessageParser<SubmitMaterialSubmitActivityMaterialCsReq> _parser = new MessageParser<SubmitMaterialSubmitActivityMaterialCsReq>(() => new SubmitMaterialSubmitActivityMaterialCsReq());

		// Token: 0x040052F4 RID: 21236
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052F5 RID: 21237
		public const int NCEJNFFMGGFFieldNumber = 13;

		// Token: 0x040052F6 RID: 21238
		private uint nCEJNFFMGGF_;
	}
}
