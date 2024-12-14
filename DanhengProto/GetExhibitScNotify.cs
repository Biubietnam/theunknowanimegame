using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200068F RID: 1679
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetExhibitScNotify : IMessage<GetExhibitScNotify>, IMessage, IEquatable<GetExhibitScNotify>, IDeepCloneable<GetExhibitScNotify>, IBufferMessage
	{
		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x000CC710 File Offset: 0x000CA910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetExhibitScNotify> Parser
		{
			get
			{
				return GetExhibitScNotify._parser;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x000CC717 File Offset: 0x000CA917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetExhibitScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x000CC729 File Offset: 0x000CA929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetExhibitScNotify.Descriptor;
			}
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x000CC730 File Offset: 0x000CA930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExhibitScNotify()
		{
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x000CC738 File Offset: 0x000CA938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExhibitScNotify(GetExhibitScNotify other) : this()
		{
			this.aGCBDGIFKJJ_ = other.aGCBDGIFKJJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x000CC75D File Offset: 0x000CA95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExhibitScNotify Clone()
		{
			return new GetExhibitScNotify(this);
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x000CC765 File Offset: 0x000CA965
		// (set) Token: 0x06004B3B RID: 19259 RVA: 0x000CC76D File Offset: 0x000CA96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AGCBDGIFKJJ
		{
			get
			{
				return this.aGCBDGIFKJJ_;
			}
			set
			{
				this.aGCBDGIFKJJ_ = value;
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x000CC776 File Offset: 0x000CA976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetExhibitScNotify);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x000CC784 File Offset: 0x000CA984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetExhibitScNotify other)
		{
			return other != null && (other == this || (this.AGCBDGIFKJJ == other.AGCBDGIFKJJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x000CC7B4 File Offset: 0x000CA9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AGCBDGIFKJJ != 0U)
			{
				num ^= this.AGCBDGIFKJJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x000CC7F3 File Offset: 0x000CA9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x000CC7FB File Offset: 0x000CA9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x000CC804 File Offset: 0x000CAA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AGCBDGIFKJJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AGCBDGIFKJJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x000CC838 File Offset: 0x000CAA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AGCBDGIFKJJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AGCBDGIFKJJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x000CC876 File Offset: 0x000CAA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetExhibitScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AGCBDGIFKJJ != 0U)
			{
				this.AGCBDGIFKJJ = other.AGCBDGIFKJJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x000CC8A7 File Offset: 0x000CAAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x000CC8B0 File Offset: 0x000CAAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AGCBDGIFKJJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001DD0 RID: 7632
		private static readonly MessageParser<GetExhibitScNotify> _parser = new MessageParser<GetExhibitScNotify>(() => new GetExhibitScNotify());

		// Token: 0x04001DD1 RID: 7633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DD2 RID: 7634
		public const int AGCBDGIFKJJFieldNumber = 6;

		// Token: 0x04001DD3 RID: 7635
		private uint aGCBDGIFKJJ_;
	}
}
