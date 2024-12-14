using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E7 RID: 231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleEventProperty : IMessage<BattleEventProperty>, IMessage, IEquatable<BattleEventProperty>, IDeepCloneable<BattleEventProperty>, IBufferMessage
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0001E654 File Offset: 0x0001C854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleEventProperty> Parser
		{
			get
			{
				return BattleEventProperty._parser;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0001E65B File Offset: 0x0001C85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleEventPropertyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001E66D File Offset: 0x0001C86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleEventProperty.Descriptor;
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0001E674 File Offset: 0x0001C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventProperty()
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001E67C File Offset: 0x0001C87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventProperty(BattleEventProperty other) : this()
		{
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0001E6B1 File Offset: 0x0001C8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventProperty Clone()
		{
			return new BattleEventProperty(this);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0001E6B9 File Offset: 0x0001C8B9
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0001E6C1 File Offset: 0x0001C8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001E6CA File Offset: 0x0001C8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleEventProperty);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleEventProperty other)
		{
			return other != null && (other == this || (object.Equals(this.SpBar, other.SpBar) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001E70C File Offset: 0x0001C90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001E748 File Offset: 0x0001C948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001E750 File Offset: 0x0001C950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0001E759 File Offset: 0x0001C959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.spBar_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0001E78C File Offset: 0x0001C98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.spBar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001E7CC File Offset: 0x0001C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleEventProperty other)
		{
			if (other == null)
			{
				return;
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001E820 File Offset: 0x0001CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001E82C File Offset: 0x0001CA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.spBar_ == null)
					{
						this.SpBar = new SpBarInfo();
					}
					input.ReadMessage(this.SpBar);
				}
			}
		}

		// Token: 0x0400044B RID: 1099
		private static readonly MessageParser<BattleEventProperty> _parser = new MessageParser<BattleEventProperty>(() => new BattleEventProperty());

		// Token: 0x0400044C RID: 1100
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400044D RID: 1101
		public const int SpBarFieldNumber = 2;

		// Token: 0x0400044E RID: 1102
		private SpBarInfo spBar_;
	}
}
