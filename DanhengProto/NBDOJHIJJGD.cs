using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C01 RID: 3073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NBDOJHIJJGD : IMessage<NBDOJHIJJGD>, IMessage, IEquatable<NBDOJHIJJGD>, IDeepCloneable<NBDOJHIJJGD>, IBufferMessage
	{
		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600880B RID: 34827 RVA: 0x00167454 File Offset: 0x00165654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NBDOJHIJJGD> Parser
		{
			get
			{
				return NBDOJHIJJGD._parser;
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600880C RID: 34828 RVA: 0x0016745B File Offset: 0x0016565B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NBDOJHIJJGDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x0016746D File Offset: 0x0016566D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NBDOJHIJJGD.Descriptor;
			}
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x00167474 File Offset: 0x00165674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBDOJHIJJGD()
		{
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x0016747C File Offset: 0x0016567C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBDOJHIJJGD(NBDOJHIJJGD other) : this()
		{
			this.iADOHKGBGML_ = other.iADOHKGBGML_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x001674A1 File Offset: 0x001656A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBDOJHIJJGD Clone()
		{
			return new NBDOJHIJJGD(this);
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x001674A9 File Offset: 0x001656A9
		// (set) Token: 0x06008812 RID: 34834 RVA: 0x001674B1 File Offset: 0x001656B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IADOHKGBGML
		{
			get
			{
				return this.iADOHKGBGML_;
			}
			set
			{
				this.iADOHKGBGML_ = value;
			}
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x001674BA File Offset: 0x001656BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NBDOJHIJJGD);
		}

		// Token: 0x06008814 RID: 34836 RVA: 0x001674C8 File Offset: 0x001656C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NBDOJHIJJGD other)
		{
			return other != null && (other == this || (this.IADOHKGBGML == other.IADOHKGBGML && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x001674F8 File Offset: 0x001656F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IADOHKGBGML != 0U)
			{
				num ^= this.IADOHKGBGML.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x00167537 File Offset: 0x00165737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x0016753F File Offset: 0x0016573F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008818 RID: 34840 RVA: 0x00167548 File Offset: 0x00165748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IADOHKGBGML != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.IADOHKGBGML);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x0016757C File Offset: 0x0016577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IADOHKGBGML != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IADOHKGBGML);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x001675BA File Offset: 0x001657BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NBDOJHIJJGD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IADOHKGBGML != 0U)
			{
				this.IADOHKGBGML = other.IADOHKGBGML;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x001675EB File Offset: 0x001657EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x001675F4 File Offset: 0x001657F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IADOHKGBGML = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400342F RID: 13359
		private static readonly MessageParser<NBDOJHIJJGD> _parser = new MessageParser<NBDOJHIJJGD>(() => new NBDOJHIJJGD());

		// Token: 0x04003430 RID: 13360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003431 RID: 13361
		public const int IADOHKGBGMLFieldNumber = 4;

		// Token: 0x04003432 RID: 13362
		private uint iADOHKGBGML_;
	}
}
