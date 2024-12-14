using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C4F RID: 3151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OfferingInfoScNotify : IMessage<OfferingInfoScNotify>, IMessage, IEquatable<OfferingInfoScNotify>, IDeepCloneable<OfferingInfoScNotify>, IBufferMessage
	{
		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06008BE3 RID: 35811 RVA: 0x00171C39 File Offset: 0x0016FE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OfferingInfoScNotify> Parser
		{
			get
			{
				return OfferingInfoScNotify._parser;
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x00171C40 File Offset: 0x0016FE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OfferingInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x00171C52 File Offset: 0x0016FE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OfferingInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x00171C59 File Offset: 0x0016FE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OfferingInfoScNotify()
		{
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x00171C61 File Offset: 0x0016FE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OfferingInfoScNotify(OfferingInfoScNotify other) : this()
		{
			this.jLEFMLADEHI_ = ((other.jLEFMLADEHI_ != null) ? other.jLEFMLADEHI_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BE8 RID: 35816 RVA: 0x00171C96 File Offset: 0x0016FE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OfferingInfoScNotify Clone()
		{
			return new OfferingInfoScNotify(this);
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x06008BE9 RID: 35817 RVA: 0x00171C9E File Offset: 0x0016FE9E
		// (set) Token: 0x06008BEA RID: 35818 RVA: 0x00171CA6 File Offset: 0x0016FEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public POPDHFEBLPG JLEFMLADEHI
		{
			get
			{
				return this.jLEFMLADEHI_;
			}
			set
			{
				this.jLEFMLADEHI_ = value;
			}
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x00171CAF File Offset: 0x0016FEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OfferingInfoScNotify);
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x00171CBD File Offset: 0x0016FEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OfferingInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.JLEFMLADEHI, other.JLEFMLADEHI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00171CF0 File Offset: 0x0016FEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jLEFMLADEHI_ != null)
			{
				num ^= this.JLEFMLADEHI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x00171D2C File Offset: 0x0016FF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x00171D34 File Offset: 0x0016FF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x00171D3D File Offset: 0x0016FF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jLEFMLADEHI_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.JLEFMLADEHI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x00171D70 File Offset: 0x0016FF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jLEFMLADEHI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JLEFMLADEHI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00171DB0 File Offset: 0x0016FFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OfferingInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jLEFMLADEHI_ != null)
			{
				if (this.jLEFMLADEHI_ == null)
				{
					this.JLEFMLADEHI = new POPDHFEBLPG();
				}
				this.JLEFMLADEHI.MergeFrom(other.JLEFMLADEHI);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x00171E04 File Offset: 0x00170004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x00171E10 File Offset: 0x00170010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.jLEFMLADEHI_ == null)
					{
						this.JLEFMLADEHI = new POPDHFEBLPG();
					}
					input.ReadMessage(this.JLEFMLADEHI);
				}
			}
		}

		// Token: 0x040035B9 RID: 13753
		private static readonly MessageParser<OfferingInfoScNotify> _parser = new MessageParser<OfferingInfoScNotify>(() => new OfferingInfoScNotify());

		// Token: 0x040035BA RID: 13754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035BB RID: 13755
		public const int JLEFMLADEHIFieldNumber = 13;

		// Token: 0x040035BC RID: 13756
		private POPDHFEBLPG jLEFMLADEHI_;
	}
}
