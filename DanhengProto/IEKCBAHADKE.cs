using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200091B RID: 2331
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IEKCBAHADKE : IMessage<IEKCBAHADKE>, IMessage, IEquatable<IEKCBAHADKE>, IDeepCloneable<IEKCBAHADKE>, IBufferMessage
	{
		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x060067F8 RID: 26616 RVA: 0x00115CD5 File Offset: 0x00113ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IEKCBAHADKE> Parser
		{
			get
			{
				return IEKCBAHADKE._parser;
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x00115CDC File Offset: 0x00113EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IEKCBAHADKEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x00115CEE File Offset: 0x00113EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IEKCBAHADKE.Descriptor;
			}
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00115CF5 File Offset: 0x00113EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IEKCBAHADKE()
		{
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x00115D00 File Offset: 0x00113F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IEKCBAHADKE(IEKCBAHADKE other) : this()
		{
			this.hEHGLEKBGBK_ = ((other.hEHGLEKBGBK_ != null) ? other.hEHGLEKBGBK_.Clone() : null);
			this.gNOCBHNGOHM_ = other.gNOCBHNGOHM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x00115D4C File Offset: 0x00113F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IEKCBAHADKE Clone()
		{
			return new IEKCBAHADKE(this);
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x060067FE RID: 26622 RVA: 0x00115D54 File Offset: 0x00113F54
		// (set) Token: 0x060067FF RID: 26623 RVA: 0x00115D5C File Offset: 0x00113F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ HEHGLEKBGBK
		{
			get
			{
				return this.hEHGLEKBGBK_;
			}
			set
			{
				this.hEHGLEKBGBK_ = value;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06006800 RID: 26624 RVA: 0x00115D65 File Offset: 0x00113F65
		// (set) Token: 0x06006801 RID: 26625 RVA: 0x00115D6D File Offset: 0x00113F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GNOCBHNGOHM
		{
			get
			{
				return this.gNOCBHNGOHM_;
			}
			set
			{
				this.gNOCBHNGOHM_ = value;
			}
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x00115D76 File Offset: 0x00113F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IEKCBAHADKE);
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x00115D84 File Offset: 0x00113F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IEKCBAHADKE other)
		{
			return other != null && (other == this || (object.Equals(this.HEHGLEKBGBK, other.HEHGLEKBGBK) && this.GNOCBHNGOHM == other.GNOCBHNGOHM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x00115DD4 File Offset: 0x00113FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hEHGLEKBGBK_ != null)
			{
				num ^= this.HEHGLEKBGBK.GetHashCode();
			}
			if (this.GNOCBHNGOHM != 0U)
			{
				num ^= this.GNOCBHNGOHM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x00115E29 File Offset: 0x00114029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x00115E31 File Offset: 0x00114031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x00115E3C File Offset: 0x0011403C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GNOCBHNGOHM != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GNOCBHNGOHM);
			}
			if (this.hEHGLEKBGBK_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.HEHGLEKBGBK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x00115E98 File Offset: 0x00114098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hEHGLEKBGBK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HEHGLEKBGBK);
			}
			if (this.GNOCBHNGOHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GNOCBHNGOHM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x00115EF0 File Offset: 0x001140F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IEKCBAHADKE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hEHGLEKBGBK_ != null)
			{
				if (this.hEHGLEKBGBK_ == null)
				{
					this.HEHGLEKBGBK = new JPEGOGNDPJJ();
				}
				this.HEHGLEKBGBK.MergeFrom(other.HEHGLEKBGBK);
			}
			if (other.GNOCBHNGOHM != 0U)
			{
				this.GNOCBHNGOHM = other.GNOCBHNGOHM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00115F58 File Offset: 0x00114158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00115F64 File Offset: 0x00114164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.hEHGLEKBGBK_ == null)
						{
							this.HEHGLEKBGBK = new JPEGOGNDPJJ();
						}
						input.ReadMessage(this.HEHGLEKBGBK);
					}
				}
				else
				{
					this.GNOCBHNGOHM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027EC RID: 10220
		private static readonly MessageParser<IEKCBAHADKE> _parser = new MessageParser<IEKCBAHADKE>(() => new IEKCBAHADKE());

		// Token: 0x040027ED RID: 10221
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027EE RID: 10222
		public const int HEHGLEKBGBKFieldNumber = 13;

		// Token: 0x040027EF RID: 10223
		private JPEGOGNDPJJ hEHGLEKBGBK_;

		// Token: 0x040027F0 RID: 10224
		public const int GNOCBHNGOHMFieldNumber = 6;

		// Token: 0x040027F1 RID: 10225
		private uint gNOCBHNGOHM_;
	}
}
