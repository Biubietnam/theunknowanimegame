using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C41 RID: 3137
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OBEPIHAHMDF : IMessage<OBEPIHAHMDF>, IMessage, IEquatable<OBEPIHAHMDF>, IDeepCloneable<OBEPIHAHMDF>, IBufferMessage
	{
		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x06008B1C RID: 35612 RVA: 0x0016F85D File Offset: 0x0016DA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OBEPIHAHMDF> Parser
		{
			get
			{
				return OBEPIHAHMDF._parser;
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06008B1D RID: 35613 RVA: 0x0016F864 File Offset: 0x0016DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OBEPIHAHMDFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06008B1E RID: 35614 RVA: 0x0016F876 File Offset: 0x0016DA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OBEPIHAHMDF.Descriptor;
			}
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x0016F87D File Offset: 0x0016DA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBEPIHAHMDF()
		{
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x0016F888 File Offset: 0x0016DA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBEPIHAHMDF(OBEPIHAHMDF other) : this()
		{
			this.id_ = other.id_;
			this.customValueList_ = ((other.customValueList_ != null) ? other.customValueList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x0016F8D4 File Offset: 0x0016DAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBEPIHAHMDF Clone()
		{
			return new OBEPIHAHMDF(this);
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x0016F8DC File Offset: 0x0016DADC
		// (set) Token: 0x06008B23 RID: 35619 RVA: 0x0016F8E4 File Offset: 0x0016DAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06008B24 RID: 35620 RVA: 0x0016F8ED File Offset: 0x0016DAED
		// (set) Token: 0x06008B25 RID: 35621 RVA: 0x0016F8F5 File Offset: 0x0016DAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValueList CustomValueList
		{
			get
			{
				return this.customValueList_;
			}
			set
			{
				this.customValueList_ = value;
			}
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x0016F8FE File Offset: 0x0016DAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OBEPIHAHMDF);
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x0016F90C File Offset: 0x0016DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OBEPIHAHMDF other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.CustomValueList, other.CustomValueList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x0016F95C File Offset: 0x0016DB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.customValueList_ != null)
			{
				num ^= this.CustomValueList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x0016F9B1 File Offset: 0x0016DBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x0016F9B9 File Offset: 0x0016DBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x0016F9C4 File Offset: 0x0016DBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Id);
			}
			if (this.customValueList_ != null)
			{
				output.WriteRawTag(194, 120);
				output.WriteMessage(this.CustomValueList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x0016FA24 File Offset: 0x0016DC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.customValueList_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CustomValueList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x0016FA7C File Offset: 0x0016DC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OBEPIHAHMDF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.customValueList_ != null)
			{
				if (this.customValueList_ == null)
				{
					this.CustomValueList = new MissionCustomValueList();
				}
				this.CustomValueList.MergeFrom(other.CustomValueList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x0016FAE4 File Offset: 0x0016DCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x0016FAF0 File Offset: 0x0016DCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 15426U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.customValueList_ == null)
						{
							this.CustomValueList = new MissionCustomValueList();
						}
						input.ReadMessage(this.CustomValueList);
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003562 RID: 13666
		private static readonly MessageParser<OBEPIHAHMDF> _parser = new MessageParser<OBEPIHAHMDF>(() => new OBEPIHAHMDF());

		// Token: 0x04003563 RID: 13667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003564 RID: 13668
		public const int IdFieldNumber = 6;

		// Token: 0x04003565 RID: 13669
		private uint id_;

		// Token: 0x04003566 RID: 13670
		public const int CustomValueListFieldNumber = 1928;

		// Token: 0x04003567 RID: 13671
		private MissionCustomValueList customValueList_;
	}
}
