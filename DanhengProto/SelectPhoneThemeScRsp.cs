using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B1 RID: 4273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectPhoneThemeScRsp : IMessage<SelectPhoneThemeScRsp>, IMessage, IEquatable<SelectPhoneThemeScRsp>, IDeepCloneable<SelectPhoneThemeScRsp>, IBufferMessage
	{
		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600BE80 RID: 48768 RVA: 0x00201129 File Offset: 0x001FF329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectPhoneThemeScRsp> Parser
		{
			get
			{
				return SelectPhoneThemeScRsp._parser;
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600BE81 RID: 48769 RVA: 0x00201130 File Offset: 0x001FF330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectPhoneThemeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600BE82 RID: 48770 RVA: 0x00201142 File Offset: 0x001FF342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectPhoneThemeScRsp.Descriptor;
			}
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x00201149 File Offset: 0x001FF349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectPhoneThemeScRsp()
		{
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x00201151 File Offset: 0x001FF351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectPhoneThemeScRsp(SelectPhoneThemeScRsp other) : this()
		{
			this.eMBLLIMNKAG_ = other.eMBLLIMNKAG_;
			this.retcode_ = other.retcode_;
			this.curPhoneTheme_ = other.curPhoneTheme_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE85 RID: 48773 RVA: 0x0020118E File Offset: 0x001FF38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectPhoneThemeScRsp Clone()
		{
			return new SelectPhoneThemeScRsp(this);
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600BE86 RID: 48774 RVA: 0x00201196 File Offset: 0x001FF396
		// (set) Token: 0x0600BE87 RID: 48775 RVA: 0x0020119E File Offset: 0x001FF39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EMBLLIMNKAG
		{
			get
			{
				return this.eMBLLIMNKAG_;
			}
			set
			{
				this.eMBLLIMNKAG_ = value;
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600BE88 RID: 48776 RVA: 0x002011A7 File Offset: 0x001FF3A7
		// (set) Token: 0x0600BE89 RID: 48777 RVA: 0x002011AF File Offset: 0x001FF3AF
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

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600BE8A RID: 48778 RVA: 0x002011B8 File Offset: 0x001FF3B8
		// (set) Token: 0x0600BE8B RID: 48779 RVA: 0x002011C0 File Offset: 0x001FF3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPhoneTheme
		{
			get
			{
				return this.curPhoneTheme_;
			}
			set
			{
				this.curPhoneTheme_ = value;
			}
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x002011C9 File Offset: 0x001FF3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectPhoneThemeScRsp);
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x002011D8 File Offset: 0x001FF3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectPhoneThemeScRsp other)
		{
			return other != null && (other == this || (this.EMBLLIMNKAG == other.EMBLLIMNKAG && this.Retcode == other.Retcode && this.CurPhoneTheme == other.CurPhoneTheme && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE8E RID: 48782 RVA: 0x00201234 File Offset: 0x001FF434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EMBLLIMNKAG != 0U)
			{
				num ^= this.EMBLLIMNKAG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurPhoneTheme != 0U)
			{
				num ^= this.CurPhoneTheme.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x002012A5 File Offset: 0x001FF4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x002012AD File Offset: 0x001FF4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x002012B8 File Offset: 0x001FF4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EMBLLIMNKAG != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EMBLLIMNKAG);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CurPhoneTheme != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CurPhoneTheme);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE92 RID: 48786 RVA: 0x00201330 File Offset: 0x001FF530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EMBLLIMNKAG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EMBLLIMNKAG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurPhoneTheme != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPhoneTheme);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x002013A0 File Offset: 0x001FF5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectPhoneThemeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EMBLLIMNKAG != 0U)
			{
				this.EMBLLIMNKAG = other.EMBLLIMNKAG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurPhoneTheme != 0U)
			{
				this.CurPhoneTheme = other.CurPhoneTheme;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE94 RID: 48788 RVA: 0x00201404 File Offset: 0x001FF604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE95 RID: 48789 RVA: 0x00201410 File Offset: 0x001FF610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurPhoneTheme = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.EMBLLIMNKAG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D63 RID: 19811
		private static readonly MessageParser<SelectPhoneThemeScRsp> _parser = new MessageParser<SelectPhoneThemeScRsp>(() => new SelectPhoneThemeScRsp());

		// Token: 0x04004D64 RID: 19812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D65 RID: 19813
		public const int EMBLLIMNKAGFieldNumber = 4;

		// Token: 0x04004D66 RID: 19814
		private uint eMBLLIMNKAG_;

		// Token: 0x04004D67 RID: 19815
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04004D68 RID: 19816
		private uint retcode_;

		// Token: 0x04004D69 RID: 19817
		public const int CurPhoneThemeFieldNumber = 14;

		// Token: 0x04004D6A RID: 19818
		private uint curPhoneTheme_;
	}
}
