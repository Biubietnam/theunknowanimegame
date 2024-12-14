using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011EF RID: 4591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StrongChallengeActivityInfo : IMessage<StrongChallengeActivityInfo>, IMessage, IEquatable<StrongChallengeActivityInfo>, IDeepCloneable<StrongChallengeActivityInfo>, IBufferMessage
	{
		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600CD36 RID: 52534 RVA: 0x00226E68 File Offset: 0x00225068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StrongChallengeActivityInfo> Parser
		{
			get
			{
				return StrongChallengeActivityInfo._parser;
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600CD37 RID: 52535 RVA: 0x00226E6F File Offset: 0x0022506F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StrongChallengeActivityInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x00226E81 File Offset: 0x00225081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StrongChallengeActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600CD39 RID: 52537 RVA: 0x00226E88 File Offset: 0x00225088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityInfo()
		{
		}

		// Token: 0x0600CD3A RID: 52538 RVA: 0x00226E9B File Offset: 0x0022509B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityInfo(StrongChallengeActivityInfo other) : this()
		{
			this.pEDHKBOHHLI_ = other.pEDHKBOHHLI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD3B RID: 52539 RVA: 0x00226EC5 File Offset: 0x002250C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityInfo Clone()
		{
			return new StrongChallengeActivityInfo(this);
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x00226ECD File Offset: 0x002250CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, StrongChallengeActivityData> PEDHKBOHHLI
		{
			get
			{
				return this.pEDHKBOHHLI_;
			}
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x00226ED5 File Offset: 0x002250D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StrongChallengeActivityInfo);
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x00226EE3 File Offset: 0x002250E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StrongChallengeActivityInfo other)
		{
			return other != null && (other == this || (this.PEDHKBOHHLI.Equals(other.PEDHKBOHHLI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x00226F18 File Offset: 0x00225118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.PEDHKBOHHLI.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD40 RID: 52544 RVA: 0x00226F4C File Offset: 0x0022514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD41 RID: 52545 RVA: 0x00226F54 File Offset: 0x00225154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD42 RID: 52546 RVA: 0x00226F5D File Offset: 0x0022515D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pEDHKBOHHLI_.WriteTo(ref output, StrongChallengeActivityInfo._map_pEDHKBOHHLI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD43 RID: 52547 RVA: 0x00226F84 File Offset: 0x00225184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pEDHKBOHHLI_.CalculateSize(StrongChallengeActivityInfo._map_pEDHKBOHHLI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD44 RID: 52548 RVA: 0x00226FBD File Offset: 0x002251BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StrongChallengeActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.pEDHKBOHHLI_.MergeFrom(other.pEDHKBOHHLI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD45 RID: 52549 RVA: 0x00226FEB File Offset: 0x002251EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD46 RID: 52550 RVA: 0x00226FF4 File Offset: 0x002251F4
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
					this.pEDHKBOHHLI_.AddEntriesFrom(ref input, StrongChallengeActivityInfo._map_pEDHKBOHHLI_codec);
				}
			}
		}

		// Token: 0x040052C6 RID: 21190
		private static readonly MessageParser<StrongChallengeActivityInfo> _parser = new MessageParser<StrongChallengeActivityInfo>(() => new StrongChallengeActivityInfo());

		// Token: 0x040052C7 RID: 21191
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052C8 RID: 21192
		public const int PEDHKBOHHLIFieldNumber = 12;

		// Token: 0x040052C9 RID: 21193
		private static readonly MapField<uint, StrongChallengeActivityData>.Codec _map_pEDHKBOHHLI_codec = new MapField<uint, StrongChallengeActivityData>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<StrongChallengeActivityData>(18U, StrongChallengeActivityData.Parser), 98U);

		// Token: 0x040052CA RID: 21194
		private readonly MapField<uint, StrongChallengeActivityData> pEDHKBOHHLI_ = new MapField<uint, StrongChallengeActivityData>();
	}
}
