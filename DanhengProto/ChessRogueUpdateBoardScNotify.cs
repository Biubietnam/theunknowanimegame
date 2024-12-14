using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002AD RID: 685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateBoardScNotify : IMessage<ChessRogueUpdateBoardScNotify>, IMessage, IEquatable<ChessRogueUpdateBoardScNotify>, IDeepCloneable<ChessRogueUpdateBoardScNotify>, IBufferMessage
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00057BCD File Offset: 0x00055DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateBoardScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateBoardScNotify._parser;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00057BD4 File Offset: 0x00055DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateBoardScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00057BE6 File Offset: 0x00055DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateBoardScNotify.Descriptor;
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00057BED File Offset: 0x00055DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateBoardScNotify()
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00057BF5 File Offset: 0x00055DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateBoardScNotify(ChessRogueUpdateBoardScNotify other) : this()
		{
			this.gDEMLJKHJBC_ = ((other.gDEMLJKHJBC_ != null) ? other.gDEMLJKHJBC_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00057C2A File Offset: 0x00055E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateBoardScNotify Clone()
		{
			return new ChessRogueUpdateBoardScNotify(this);
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00057C32 File Offset: 0x00055E32
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00057C3A File Offset: 0x00055E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellInfo GDEMLJKHJBC
		{
			get
			{
				return this.gDEMLJKHJBC_;
			}
			set
			{
				this.gDEMLJKHJBC_ = value;
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00057C43 File Offset: 0x00055E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateBoardScNotify);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00057C51 File Offset: 0x00055E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateBoardScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GDEMLJKHJBC, other.GDEMLJKHJBC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00057C84 File Offset: 0x00055E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gDEMLJKHJBC_ != null)
			{
				num ^= this.GDEMLJKHJBC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00057CC0 File Offset: 0x00055EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00057CC8 File Offset: 0x00055EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00057CD1 File Offset: 0x00055ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gDEMLJKHJBC_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.GDEMLJKHJBC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00057D04 File Offset: 0x00055F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gDEMLJKHJBC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GDEMLJKHJBC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00057D44 File Offset: 0x00055F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateBoardScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gDEMLJKHJBC_ != null)
			{
				if (this.gDEMLJKHJBC_ == null)
				{
					this.GDEMLJKHJBC = new CellInfo();
				}
				this.GDEMLJKHJBC.MergeFrom(other.GDEMLJKHJBC);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00057D98 File Offset: 0x00055F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00057DA4 File Offset: 0x00055FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.gDEMLJKHJBC_ == null)
					{
						this.GDEMLJKHJBC = new CellInfo();
					}
					input.ReadMessage(this.GDEMLJKHJBC);
				}
			}
		}

		// Token: 0x04000CC5 RID: 3269
		private static readonly MessageParser<ChessRogueUpdateBoardScNotify> _parser = new MessageParser<ChessRogueUpdateBoardScNotify>(() => new ChessRogueUpdateBoardScNotify());

		// Token: 0x04000CC6 RID: 3270
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CC7 RID: 3271
		public const int GDEMLJKHJBCFieldNumber = 12;

		// Token: 0x04000CC8 RID: 3272
		private CellInfo gDEMLJKHJBC_;
	}
}
