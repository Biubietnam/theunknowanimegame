using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AA9 RID: 2729
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeSyncDataScNotify : IMessage<MatchThreeSyncDataScNotify>, IMessage, IEquatable<MatchThreeSyncDataScNotify>, IDeepCloneable<MatchThreeSyncDataScNotify>, IBufferMessage
	{
		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x060078F6 RID: 30966 RVA: 0x001409FD File Offset: 0x0013EBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeSyncDataScNotify> Parser
		{
			get
			{
				return MatchThreeSyncDataScNotify._parser;
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x00140A04 File Offset: 0x0013EC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeSyncDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x060078F8 RID: 30968 RVA: 0x00140A16 File Offset: 0x0013EC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeSyncDataScNotify.Descriptor;
			}
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00140A1D File Offset: 0x0013EC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSyncDataScNotify()
		{
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x00140A25 File Offset: 0x0013EC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSyncDataScNotify(MatchThreeSyncDataScNotify other) : this()
		{
			this.lCPHAAIIPOJ_ = ((other.lCPHAAIIPOJ_ != null) ? other.lCPHAAIIPOJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x00140A5A File Offset: 0x0013EC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSyncDataScNotify Clone()
		{
			return new MatchThreeSyncDataScNotify(this);
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x060078FC RID: 30972 RVA: 0x00140A62 File Offset: 0x0013EC62
		// (set) Token: 0x060078FD RID: 30973 RVA: 0x00140A6A File Offset: 0x0013EC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBKKDOPNNJA LCPHAAIIPOJ
		{
			get
			{
				return this.lCPHAAIIPOJ_;
			}
			set
			{
				this.lCPHAAIIPOJ_ = value;
			}
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x00140A73 File Offset: 0x0013EC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeSyncDataScNotify);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x00140A81 File Offset: 0x0013EC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeSyncDataScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LCPHAAIIPOJ, other.LCPHAAIIPOJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x00140AB4 File Offset: 0x0013ECB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lCPHAAIIPOJ_ != null)
			{
				num ^= this.LCPHAAIIPOJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00140AF0 File Offset: 0x0013ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x00140AF8 File Offset: 0x0013ECF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00140B01 File Offset: 0x0013ED01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lCPHAAIIPOJ_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LCPHAAIIPOJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00140B34 File Offset: 0x0013ED34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lCPHAAIIPOJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LCPHAAIIPOJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x00140B74 File Offset: 0x0013ED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeSyncDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lCPHAAIIPOJ_ != null)
			{
				if (this.lCPHAAIIPOJ_ == null)
				{
					this.LCPHAAIIPOJ = new PBKKDOPNNJA();
				}
				this.LCPHAAIIPOJ.MergeFrom(other.LCPHAAIIPOJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x00140BC8 File Offset: 0x0013EDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x00140BD4 File Offset: 0x0013EDD4
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
					if (this.lCPHAAIIPOJ_ == null)
					{
						this.LCPHAAIIPOJ = new PBKKDOPNNJA();
					}
					input.ReadMessage(this.LCPHAAIIPOJ);
				}
			}
		}

		// Token: 0x04002E71 RID: 11889
		private static readonly MessageParser<MatchThreeSyncDataScNotify> _parser = new MessageParser<MatchThreeSyncDataScNotify>(() => new MatchThreeSyncDataScNotify());

		// Token: 0x04002E72 RID: 11890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E73 RID: 11891
		public const int LCPHAAIIPOJFieldNumber = 3;

		// Token: 0x04002E74 RID: 11892
		private PBKKDOPNNJA lCPHAAIIPOJ_;
	}
}
