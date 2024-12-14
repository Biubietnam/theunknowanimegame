using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F67 RID: 3943
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueReforgeFormulaSelectInfo : IMessage<RogueReforgeFormulaSelectInfo>, IMessage, IEquatable<RogueReforgeFormulaSelectInfo>, IDeepCloneable<RogueReforgeFormulaSelectInfo>, IBufferMessage
	{
		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x001D8227 File Offset: 0x001D6427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueReforgeFormulaSelectInfo> Parser
		{
			get
			{
				return RogueReforgeFormulaSelectInfo._parser;
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x001D822E File Offset: 0x001D642E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueReforgeFormulaSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x001D8240 File Offset: 0x001D6440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueReforgeFormulaSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x001D8247 File Offset: 0x001D6447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectInfo()
		{
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x001D824F File Offset: 0x001D644F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectInfo(RogueReforgeFormulaSelectInfo other) : this()
		{
			this.rogueFormulaSelectInfo_ = ((other.rogueFormulaSelectInfo_ != null) ? other.rogueFormulaSelectInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x001D8284 File Offset: 0x001D6484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectInfo Clone()
		{
			return new RogueReforgeFormulaSelectInfo(this);
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600AFC6 RID: 44998 RVA: 0x001D828C File Offset: 0x001D648C
		// (set) Token: 0x0600AFC7 RID: 44999 RVA: 0x001D8294 File Offset: 0x001D6494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFormulaSelectInfo RogueFormulaSelectInfo
		{
			get
			{
				return this.rogueFormulaSelectInfo_;
			}
			set
			{
				this.rogueFormulaSelectInfo_ = value;
			}
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x001D829D File Offset: 0x001D649D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueReforgeFormulaSelectInfo);
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x001D82AB File Offset: 0x001D64AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueReforgeFormulaSelectInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueFormulaSelectInfo, other.RogueFormulaSelectInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x001D82E0 File Offset: 0x001D64E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueFormulaSelectInfo_ != null)
			{
				num ^= this.RogueFormulaSelectInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x001D831C File Offset: 0x001D651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x001D8324 File Offset: 0x001D6524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x001D832D File Offset: 0x001D652D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueFormulaSelectInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueFormulaSelectInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x001D8360 File Offset: 0x001D6560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueFormulaSelectInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFormulaSelectInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x001D83A0 File Offset: 0x001D65A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueReforgeFormulaSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueFormulaSelectInfo_ != null)
			{
				if (this.rogueFormulaSelectInfo_ == null)
				{
					this.RogueFormulaSelectInfo = new RogueFormulaSelectInfo();
				}
				this.RogueFormulaSelectInfo.MergeFrom(other.RogueFormulaSelectInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x001D83F4 File Offset: 0x001D65F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x001D8400 File Offset: 0x001D6600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueFormulaSelectInfo_ == null)
					{
						this.RogueFormulaSelectInfo = new RogueFormulaSelectInfo();
					}
					input.ReadMessage(this.RogueFormulaSelectInfo);
				}
			}
		}

		// Token: 0x04004778 RID: 18296
		private static readonly MessageParser<RogueReforgeFormulaSelectInfo> _parser = new MessageParser<RogueReforgeFormulaSelectInfo>(() => new RogueReforgeFormulaSelectInfo());

		// Token: 0x04004779 RID: 18297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400477A RID: 18298
		public const int RogueFormulaSelectInfoFieldNumber = 3;

		// Token: 0x0400477B RID: 18299
		private RogueFormulaSelectInfo rogueFormulaSelectInfo_;
	}
}
