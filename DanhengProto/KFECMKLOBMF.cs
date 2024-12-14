using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000997 RID: 2455
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KFECMKLOBMF : IMessage<KFECMKLOBMF>, IMessage, IEquatable<KFECMKLOBMF>, IDeepCloneable<KFECMKLOBMF>, IBufferMessage
	{
		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06006DD7 RID: 28119 RVA: 0x001259D0 File Offset: 0x00123BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KFECMKLOBMF> Parser
		{
			get
			{
				return KFECMKLOBMF._parser;
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x001259D7 File Offset: 0x00123BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KFECMKLOBMFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x001259E9 File Offset: 0x00123BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KFECMKLOBMF.Descriptor;
			}
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x001259F0 File Offset: 0x00123BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFECMKLOBMF()
		{
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x001259F8 File Offset: 0x00123BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFECMKLOBMF(KFECMKLOBMF other) : this()
		{
			this.oBCNIOBNJAE_ = ((other.oBCNIOBNJAE_ != null) ? other.oBCNIOBNJAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x00125A2D File Offset: 0x00123C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFECMKLOBMF Clone()
		{
			return new KFECMKLOBMF(this);
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06006DDD RID: 28125 RVA: 0x00125A35 File Offset: 0x00123C35
		// (set) Token: 0x06006DDE RID: 28126 RVA: 0x00125A3D File Offset: 0x00123C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPEDPGPEMGH OBCNIOBNJAE
		{
			get
			{
				return this.oBCNIOBNJAE_;
			}
			set
			{
				this.oBCNIOBNJAE_ = value;
			}
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x00125A46 File Offset: 0x00123C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KFECMKLOBMF);
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x00125A54 File Offset: 0x00123C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KFECMKLOBMF other)
		{
			return other != null && (other == this || (object.Equals(this.OBCNIOBNJAE, other.OBCNIOBNJAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x00125A88 File Offset: 0x00123C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.oBCNIOBNJAE_ != null)
			{
				num ^= this.OBCNIOBNJAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x00125AC4 File Offset: 0x00123CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x00125ACC File Offset: 0x00123CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x00125AD5 File Offset: 0x00123CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oBCNIOBNJAE_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.OBCNIOBNJAE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x00125B08 File Offset: 0x00123D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.oBCNIOBNJAE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OBCNIOBNJAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x00125B48 File Offset: 0x00123D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KFECMKLOBMF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.oBCNIOBNJAE_ != null)
			{
				if (this.oBCNIOBNJAE_ == null)
				{
					this.OBCNIOBNJAE = new MPEDPGPEMGH();
				}
				this.OBCNIOBNJAE.MergeFrom(other.OBCNIOBNJAE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00125B9C File Offset: 0x00123D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x00125BA8 File Offset: 0x00123DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.oBCNIOBNJAE_ == null)
					{
						this.OBCNIOBNJAE = new MPEDPGPEMGH();
					}
					input.ReadMessage(this.OBCNIOBNJAE);
				}
			}
		}

		// Token: 0x04002A31 RID: 10801
		private static readonly MessageParser<KFECMKLOBMF> _parser = new MessageParser<KFECMKLOBMF>(() => new KFECMKLOBMF());

		// Token: 0x04002A32 RID: 10802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A33 RID: 10803
		public const int OBCNIOBNJAEFieldNumber = 1;

		// Token: 0x04002A34 RID: 10804
		private MPEDPGPEMGH oBCNIOBNJAE_;
	}
}
