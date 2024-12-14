using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C4D RID: 3149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OEMCBINHGOA : IMessage<OEMCBINHGOA>, IMessage, IEquatable<OEMCBINHGOA>, IDeepCloneable<OEMCBINHGOA>, IBufferMessage
	{
		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x06008BCA RID: 35786 RVA: 0x00171855 File Offset: 0x0016FA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OEMCBINHGOA> Parser
		{
			get
			{
				return OEMCBINHGOA._parser;
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x06008BCB RID: 35787 RVA: 0x0017185C File Offset: 0x0016FA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OEMCBINHGOAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x06008BCC RID: 35788 RVA: 0x0017186E File Offset: 0x0016FA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OEMCBINHGOA.Descriptor;
			}
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x00171875 File Offset: 0x0016FA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEMCBINHGOA()
		{
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x0017187D File Offset: 0x0016FA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEMCBINHGOA(OEMCBINHGOA other) : this()
		{
			this.iMFMOFJGONC_ = other.iMFMOFJGONC_;
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.iGFNCGIKAIP_ = other.iGFNCGIKAIP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x001718BA File Offset: 0x0016FABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEMCBINHGOA Clone()
		{
			return new OEMCBINHGOA(this);
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x001718C2 File Offset: 0x0016FAC2
		// (set) Token: 0x06008BD1 RID: 35793 RVA: 0x001718CA File Offset: 0x0016FACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong IMFMOFJGONC
		{
			get
			{
				return this.iMFMOFJGONC_;
			}
			set
			{
				this.iMFMOFJGONC_ = value;
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x001718D3 File Offset: 0x0016FAD3
		// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x001718DB File Offset: 0x0016FADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGAIAJAKPEI
		{
			get
			{
				return this.mGAIAJAKPEI_;
			}
			set
			{
				this.mGAIAJAKPEI_ = value;
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x001718E4 File Offset: 0x0016FAE4
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x001718EC File Offset: 0x0016FAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IGFNCGIKAIP
		{
			get
			{
				return this.iGFNCGIKAIP_;
			}
			set
			{
				this.iGFNCGIKAIP_ = value;
			}
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x001718F5 File Offset: 0x0016FAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OEMCBINHGOA);
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x00171904 File Offset: 0x0016FB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OEMCBINHGOA other)
		{
			return other != null && (other == this || (this.IMFMOFJGONC == other.IMFMOFJGONC && this.MGAIAJAKPEI == other.MGAIAJAKPEI && this.IGFNCGIKAIP == other.IGFNCGIKAIP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x00171960 File Offset: 0x0016FB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IMFMOFJGONC != 0UL)
			{
				num ^= this.IMFMOFJGONC.GetHashCode();
			}
			if (this.MGAIAJAKPEI != 0U)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			if (this.IGFNCGIKAIP != 0U)
			{
				num ^= this.IGFNCGIKAIP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x001719D1 File Offset: 0x0016FBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x001719D9 File Offset: 0x0016FBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x001719E4 File Offset: 0x0016FBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IMFMOFJGONC != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.IMFMOFJGONC);
			}
			if (this.MGAIAJAKPEI != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MGAIAJAKPEI);
			}
			if (this.IGFNCGIKAIP != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.IGFNCGIKAIP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x00171A58 File Offset: 0x0016FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IMFMOFJGONC != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.IMFMOFJGONC);
			}
			if (this.MGAIAJAKPEI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGAIAJAKPEI);
			}
			if (this.IGFNCGIKAIP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IGFNCGIKAIP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x00171AC8 File Offset: 0x0016FCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OEMCBINHGOA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IMFMOFJGONC != 0UL)
			{
				this.IMFMOFJGONC = other.IMFMOFJGONC;
			}
			if (other.MGAIAJAKPEI != 0U)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			if (other.IGFNCGIKAIP != 0U)
			{
				this.IGFNCGIKAIP = other.IGFNCGIKAIP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x00171B2C File Offset: 0x0016FD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x00171B38 File Offset: 0x0016FD38
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IGFNCGIKAIP = input.ReadUInt32();
						}
					}
					else
					{
						this.MGAIAJAKPEI = input.ReadUInt32();
					}
				}
				else
				{
					this.IMFMOFJGONC = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040035B0 RID: 13744
		private static readonly MessageParser<OEMCBINHGOA> _parser = new MessageParser<OEMCBINHGOA>(() => new OEMCBINHGOA());

		// Token: 0x040035B1 RID: 13745
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B2 RID: 13746
		public const int IMFMOFJGONCFieldNumber = 1;

		// Token: 0x040035B3 RID: 13747
		private ulong iMFMOFJGONC_;

		// Token: 0x040035B4 RID: 13748
		public const int MGAIAJAKPEIFieldNumber = 2;

		// Token: 0x040035B5 RID: 13749
		private uint mGAIAJAKPEI_;

		// Token: 0x040035B6 RID: 13750
		public const int IGFNCGIKAIPFieldNumber = 3;

		// Token: 0x040035B7 RID: 13751
		private uint iGFNCGIKAIP_;
	}
}
