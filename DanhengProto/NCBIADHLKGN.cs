using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C03 RID: 3075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NCBIADHLKGN : IMessage<NCBIADHLKGN>, IMessage, IEquatable<NCBIADHLKGN>, IDeepCloneable<NCBIADHLKGN>, IBufferMessage
	{
		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x001676D1 File Offset: 0x001658D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NCBIADHLKGN> Parser
		{
			get
			{
				return NCBIADHLKGN._parser;
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06008821 RID: 34849 RVA: 0x001676D8 File Offset: 0x001658D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NCBIADHLKGNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x001676EA File Offset: 0x001658EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NCBIADHLKGN.Descriptor;
			}
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x001676F1 File Offset: 0x001658F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCBIADHLKGN()
		{
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x001676F9 File Offset: 0x001658F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCBIADHLKGN(NCBIADHLKGN other) : this()
		{
			this.updateScepterInfo_ = ((other.updateScepterInfo_ != null) ? other.updateScepterInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x0016772E File Offset: 0x0016592E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCBIADHLKGN Clone()
		{
			return new NCBIADHLKGN(this);
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06008826 RID: 34854 RVA: 0x00167736 File Offset: 0x00165936
		// (set) Token: 0x06008827 RID: 34855 RVA: 0x0016773E File Offset: 0x0016593E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo UpdateScepterInfo
		{
			get
			{
				return this.updateScepterInfo_;
			}
			set
			{
				this.updateScepterInfo_ = value;
			}
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x00167747 File Offset: 0x00165947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NCBIADHLKGN);
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x00167755 File Offset: 0x00165955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NCBIADHLKGN other)
		{
			return other != null && (other == this || (object.Equals(this.UpdateScepterInfo, other.UpdateScepterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x00167788 File Offset: 0x00165988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.updateScepterInfo_ != null)
			{
				num ^= this.UpdateScepterInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x001677C4 File Offset: 0x001659C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x001677CC File Offset: 0x001659CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x001677D5 File Offset: 0x001659D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.updateScepterInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.UpdateScepterInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x00167808 File Offset: 0x00165A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.updateScepterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateScepterInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x00167848 File Offset: 0x00165A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NCBIADHLKGN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.updateScepterInfo_ != null)
			{
				if (this.updateScepterInfo_ == null)
				{
					this.UpdateScepterInfo = new RogueMagicGameScepterInfo();
				}
				this.UpdateScepterInfo.MergeFrom(other.UpdateScepterInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008830 RID: 34864 RVA: 0x0016789C File Offset: 0x00165A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x001678A8 File Offset: 0x00165AA8
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
					if (this.updateScepterInfo_ == null)
					{
						this.UpdateScepterInfo = new RogueMagicGameScepterInfo();
					}
					input.ReadMessage(this.UpdateScepterInfo);
				}
			}
		}

		// Token: 0x04003434 RID: 13364
		private static readonly MessageParser<NCBIADHLKGN> _parser = new MessageParser<NCBIADHLKGN>(() => new NCBIADHLKGN());

		// Token: 0x04003435 RID: 13365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003436 RID: 13366
		public const int UpdateScepterInfoFieldNumber = 13;

		// Token: 0x04003437 RID: 13367
		private RogueMagicGameScepterInfo updateScepterInfo_;
	}
}
