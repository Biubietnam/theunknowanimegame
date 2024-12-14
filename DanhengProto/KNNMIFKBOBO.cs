using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009CB RID: 2507
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KNNMIFKBOBO : IMessage<KNNMIFKBOBO>, IMessage, IEquatable<KNNMIFKBOBO>, IDeepCloneable<KNNMIFKBOBO>, IBufferMessage
	{
		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06006FCF RID: 28623 RVA: 0x0012A794 File Offset: 0x00128994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KNNMIFKBOBO> Parser
		{
			get
			{
				return KNNMIFKBOBO._parser;
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x0012A79B File Offset: 0x0012899B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KNNMIFKBOBOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06006FD1 RID: 28625 RVA: 0x0012A7AD File Offset: 0x001289AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KNNMIFKBOBO.Descriptor;
			}
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x0012A7B4 File Offset: 0x001289B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNNMIFKBOBO()
		{
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x0012A7BC File Offset: 0x001289BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNNMIFKBOBO(KNNMIFKBOBO other) : this()
		{
			this.eKEHNBIIHFF_ = other.eKEHNBIIHFF_;
			this.bPNDFBPMOEL_ = other.bPNDFBPMOEL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x0012A7ED File Offset: 0x001289ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNNMIFKBOBO Clone()
		{
			return new KNNMIFKBOBO(this);
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06006FD5 RID: 28629 RVA: 0x0012A7F5 File Offset: 0x001289F5
		// (set) Token: 0x06006FD6 RID: 28630 RVA: 0x0012A7FD File Offset: 0x001289FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKEHNBIIHFF
		{
			get
			{
				return this.eKEHNBIIHFF_;
			}
			set
			{
				this.eKEHNBIIHFF_ = value;
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x0012A806 File Offset: 0x00128A06
		// (set) Token: 0x06006FD8 RID: 28632 RVA: 0x0012A80E File Offset: 0x00128A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BPNDFBPMOEL
		{
			get
			{
				return this.bPNDFBPMOEL_;
			}
			set
			{
				this.bPNDFBPMOEL_ = value;
			}
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x0012A817 File Offset: 0x00128A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KNNMIFKBOBO);
		}

		// Token: 0x06006FDA RID: 28634 RVA: 0x0012A825 File Offset: 0x00128A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KNNMIFKBOBO other)
		{
			return other != null && (other == this || (this.EKEHNBIIHFF == other.EKEHNBIIHFF && this.BPNDFBPMOEL == other.BPNDFBPMOEL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x0012A864 File Offset: 0x00128A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EKEHNBIIHFF != 0U)
			{
				num ^= this.EKEHNBIIHFF.GetHashCode();
			}
			if (this.BPNDFBPMOEL != 0U)
			{
				num ^= this.BPNDFBPMOEL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x0012A8BC File Offset: 0x00128ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x0012A8C4 File Offset: 0x00128AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x0012A8D0 File Offset: 0x00128AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BPNDFBPMOEL != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BPNDFBPMOEL);
			}
			if (this.EKEHNBIIHFF != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EKEHNBIIHFF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x0012A92C File Offset: 0x00128B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EKEHNBIIHFF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKEHNBIIHFF);
			}
			if (this.BPNDFBPMOEL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BPNDFBPMOEL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x0012A984 File Offset: 0x00128B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KNNMIFKBOBO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EKEHNBIIHFF != 0U)
			{
				this.EKEHNBIIHFF = other.EKEHNBIIHFF;
			}
			if (other.BPNDFBPMOEL != 0U)
			{
				this.BPNDFBPMOEL = other.BPNDFBPMOEL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x0012A9D4 File Offset: 0x00128BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x0012A9E0 File Offset: 0x00128BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EKEHNBIIHFF = input.ReadUInt32();
					}
				}
				else
				{
					this.BPNDFBPMOEL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B05 RID: 11013
		private static readonly MessageParser<KNNMIFKBOBO> _parser = new MessageParser<KNNMIFKBOBO>(() => new KNNMIFKBOBO());

		// Token: 0x04002B06 RID: 11014
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B07 RID: 11015
		public const int EKEHNBIIHFFFieldNumber = 14;

		// Token: 0x04002B08 RID: 11016
		private uint eKEHNBIIHFF_;

		// Token: 0x04002B09 RID: 11017
		public const int BPNDFBPMOELFieldNumber = 12;

		// Token: 0x04002B0A RID: 11018
		private uint bPNDFBPMOEL_;
	}
}
