using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009B5 RID: 2485
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KJDLBJHAPMJ : IMessage<KJDLBJHAPMJ>, IMessage, IEquatable<KJDLBJHAPMJ>, IDeepCloneable<KJDLBJHAPMJ>, IBufferMessage
	{
		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x001289D5 File Offset: 0x00126BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KJDLBJHAPMJ> Parser
		{
			get
			{
				return KJDLBJHAPMJ._parser;
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x001289DC File Offset: 0x00126BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KJDLBJHAPMJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x001289EE File Offset: 0x00126BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KJDLBJHAPMJ.Descriptor;
			}
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x001289F5 File Offset: 0x00126BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJDLBJHAPMJ()
		{
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00128A00 File Offset: 0x00126C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJDLBJHAPMJ(KJDLBJHAPMJ other) : this()
		{
			this.dHCGIBDHJDL_ = other.dHCGIBDHJDL_;
			this.pLFPJDMGBBN_ = other.pLFPJDMGBBN_;
			this.oBKACOOGINE_ = other.oBKACOOGINE_;
			this.cBGOLDAOFMH_ = other.cBGOLDAOFMH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x00128A54 File Offset: 0x00126C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJDLBJHAPMJ Clone()
		{
			return new KJDLBJHAPMJ(this);
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x00128A5C File Offset: 0x00126C5C
		// (set) Token: 0x06006F15 RID: 28437 RVA: 0x00128A64 File Offset: 0x00126C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DHCGIBDHJDL
		{
			get
			{
				return this.dHCGIBDHJDL_;
			}
			set
			{
				this.dHCGIBDHJDL_ = value;
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06006F16 RID: 28438 RVA: 0x00128A6D File Offset: 0x00126C6D
		// (set) Token: 0x06006F17 RID: 28439 RVA: 0x00128A75 File Offset: 0x00126C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PLFPJDMGBBN
		{
			get
			{
				return this.pLFPJDMGBBN_;
			}
			set
			{
				this.pLFPJDMGBBN_ = value;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x00128A7E File Offset: 0x00126C7E
		// (set) Token: 0x06006F19 RID: 28441 RVA: 0x00128A86 File Offset: 0x00126C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OBKACOOGINE
		{
			get
			{
				return this.oBKACOOGINE_;
			}
			set
			{
				this.oBKACOOGINE_ = value;
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x00128A8F File Offset: 0x00126C8F
		// (set) Token: 0x06006F1B RID: 28443 RVA: 0x00128A97 File Offset: 0x00126C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CBGOLDAOFMH
		{
			get
			{
				return this.cBGOLDAOFMH_;
			}
			set
			{
				this.cBGOLDAOFMH_ = value;
			}
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00128AA0 File Offset: 0x00126CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KJDLBJHAPMJ);
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00128AB0 File Offset: 0x00126CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KJDLBJHAPMJ other)
		{
			return other != null && (other == this || (this.DHCGIBDHJDL == other.DHCGIBDHJDL && this.PLFPJDMGBBN == other.PLFPJDMGBBN && this.OBKACOOGINE == other.OBKACOOGINE && this.CBGOLDAOFMH == other.CBGOLDAOFMH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00128B1C File Offset: 0x00126D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DHCGIBDHJDL != 0U)
			{
				num ^= this.DHCGIBDHJDL.GetHashCode();
			}
			if (this.PLFPJDMGBBN)
			{
				num ^= this.PLFPJDMGBBN.GetHashCode();
			}
			if (this.OBKACOOGINE != 0U)
			{
				num ^= this.OBKACOOGINE.GetHashCode();
			}
			if (this.CBGOLDAOFMH != 0U)
			{
				num ^= this.CBGOLDAOFMH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00128BA6 File Offset: 0x00126DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00128BAE File Offset: 0x00126DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00128BB8 File Offset: 0x00126DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PLFPJDMGBBN)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.PLFPJDMGBBN);
			}
			if (this.CBGOLDAOFMH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CBGOLDAOFMH);
			}
			if (this.OBKACOOGINE != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OBKACOOGINE);
			}
			if (this.DHCGIBDHJDL != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.DHCGIBDHJDL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00128C4C File Offset: 0x00126E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DHCGIBDHJDL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DHCGIBDHJDL);
			}
			if (this.PLFPJDMGBBN)
			{
				num += 2;
			}
			if (this.OBKACOOGINE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OBKACOOGINE);
			}
			if (this.CBGOLDAOFMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CBGOLDAOFMH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00128CC8 File Offset: 0x00126EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KJDLBJHAPMJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DHCGIBDHJDL != 0U)
			{
				this.DHCGIBDHJDL = other.DHCGIBDHJDL;
			}
			if (other.PLFPJDMGBBN)
			{
				this.PLFPJDMGBBN = other.PLFPJDMGBBN;
			}
			if (other.OBKACOOGINE != 0U)
			{
				this.OBKACOOGINE = other.OBKACOOGINE;
			}
			if (other.CBGOLDAOFMH != 0U)
			{
				this.CBGOLDAOFMH = other.CBGOLDAOFMH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00128D40 File Offset: 0x00126F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00128D4C File Offset: 0x00126F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 48U)
					{
						this.PLFPJDMGBBN = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.CBGOLDAOFMH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.OBKACOOGINE = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.DHCGIBDHJDL = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AA9 RID: 10921
		private static readonly MessageParser<KJDLBJHAPMJ> _parser = new MessageParser<KJDLBJHAPMJ>(() => new KJDLBJHAPMJ());

		// Token: 0x04002AAA RID: 10922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AAB RID: 10923
		public const int DHCGIBDHJDLFieldNumber = 14;

		// Token: 0x04002AAC RID: 10924
		private uint dHCGIBDHJDL_;

		// Token: 0x04002AAD RID: 10925
		public const int PLFPJDMGBBNFieldNumber = 6;

		// Token: 0x04002AAE RID: 10926
		private bool pLFPJDMGBBN_;

		// Token: 0x04002AAF RID: 10927
		public const int OBKACOOGINEFieldNumber = 12;

		// Token: 0x04002AB0 RID: 10928
		private uint oBKACOOGINE_;

		// Token: 0x04002AB1 RID: 10929
		public const int CBGOLDAOFMHFieldNumber = 11;

		// Token: 0x04002AB2 RID: 10930
		private uint cBGOLDAOFMH_;
	}
}
