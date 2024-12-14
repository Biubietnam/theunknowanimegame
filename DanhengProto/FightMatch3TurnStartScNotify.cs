using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000557 RID: 1367
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3TurnStartScNotify : IMessage<FightMatch3TurnStartScNotify>, IMessage, IEquatable<FightMatch3TurnStartScNotify>, IDeepCloneable<FightMatch3TurnStartScNotify>, IBufferMessage
	{
		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x000A7101 File Offset: 0x000A5301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3TurnStartScNotify> Parser
		{
			get
			{
				return FightMatch3TurnStartScNotify._parser;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x000A7108 File Offset: 0x000A5308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3TurnStartScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x000A711A File Offset: 0x000A531A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3TurnStartScNotify.Descriptor;
			}
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x000A7121 File Offset: 0x000A5321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3TurnStartScNotify()
		{
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x000A7129 File Offset: 0x000A5329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3TurnStartScNotify(FightMatch3TurnStartScNotify other) : this()
		{
			this.lAOHPKGKKGO_ = ((other.lAOHPKGKKGO_ != null) ? other.lAOHPKGKKGO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x000A715E File Offset: 0x000A535E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3TurnStartScNotify Clone()
		{
			return new FightMatch3TurnStartScNotify(this);
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x000A7166 File Offset: 0x000A5366
		// (set) Token: 0x06003CFA RID: 15610 RVA: 0x000A716E File Offset: 0x000A536E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA LAOHPKGKKGO
		{
			get
			{
				return this.lAOHPKGKKGO_;
			}
			set
			{
				this.lAOHPKGKKGO_ = value;
			}
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x000A7177 File Offset: 0x000A5377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3TurnStartScNotify);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x000A7185 File Offset: 0x000A5385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3TurnStartScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LAOHPKGKKGO, other.LAOHPKGKKGO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x000A71B8 File Offset: 0x000A53B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lAOHPKGKKGO_ != null)
			{
				num ^= this.LAOHPKGKKGO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x000A71F4 File Offset: 0x000A53F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x000A71FC File Offset: 0x000A53FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x000A7205 File Offset: 0x000A5405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lAOHPKGKKGO_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.LAOHPKGKKGO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x000A7238 File Offset: 0x000A5438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lAOHPKGKKGO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LAOHPKGKKGO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x000A7278 File Offset: 0x000A5478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3TurnStartScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lAOHPKGKKGO_ != null)
			{
				if (this.lAOHPKGKKGO_ == null)
				{
					this.LAOHPKGKKGO = new CFHPMBOAHLA();
				}
				this.LAOHPKGKKGO.MergeFrom(other.LAOHPKGKKGO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x000A72CC File Offset: 0x000A54CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x000A72D8 File Offset: 0x000A54D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.lAOHPKGKKGO_ == null)
					{
						this.LAOHPKGKKGO = new CFHPMBOAHLA();
					}
					input.ReadMessage(this.LAOHPKGKKGO);
				}
			}
		}

		// Token: 0x04001870 RID: 6256
		private static readonly MessageParser<FightMatch3TurnStartScNotify> _parser = new MessageParser<FightMatch3TurnStartScNotify>(() => new FightMatch3TurnStartScNotify());

		// Token: 0x04001871 RID: 6257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001872 RID: 6258
		public const int LAOHPKGKKGOFieldNumber = 11;

		// Token: 0x04001873 RID: 6259
		private CFHPMBOAHLA lAOHPKGKKGO_;
	}
}
