using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C1 RID: 2241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusLineupUpdateScNotify : IMessage<HeliobusLineupUpdateScNotify>, IMessage, IEquatable<HeliobusLineupUpdateScNotify>, IDeepCloneable<HeliobusLineupUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x0010BBCB File Offset: 0x00109DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusLineupUpdateScNotify> Parser
		{
			get
			{
				return HeliobusLineupUpdateScNotify._parser;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x060063ED RID: 25581 RVA: 0x0010BBD2 File Offset: 0x00109DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusLineupUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x060063EE RID: 25582 RVA: 0x0010BBE4 File Offset: 0x00109DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusLineupUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x0010BBEB File Offset: 0x00109DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusLineupUpdateScNotify()
		{
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x0010BBF3 File Offset: 0x00109DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusLineupUpdateScNotify(HeliobusLineupUpdateScNotify other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0010BC28 File Offset: 0x00109E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusLineupUpdateScNotify Clone()
		{
			return new HeliobusLineupUpdateScNotify(this);
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x0010BC30 File Offset: 0x00109E30
		// (set) Token: 0x060063F3 RID: 25587 RVA: 0x0010BC38 File Offset: 0x00109E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeLineup Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0010BC41 File Offset: 0x00109E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusLineupUpdateScNotify);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x0010BC4F File Offset: 0x00109E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusLineupUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x0010BC84 File Offset: 0x00109E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0010BCC0 File Offset: 0x00109EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0010BCC8 File Offset: 0x00109EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0010BCD1 File Offset: 0x00109ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lineup_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0010BD04 File Offset: 0x00109F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0010BD44 File Offset: 0x00109F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusLineupUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new HeliobusChallengeLineup();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0010BD98 File Offset: 0x00109F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0010BDA4 File Offset: 0x00109FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.lineup_ == null)
					{
						this.Lineup = new HeliobusChallengeLineup();
					}
					input.ReadMessage(this.Lineup);
				}
			}
		}

		// Token: 0x04002689 RID: 9865
		private static readonly MessageParser<HeliobusLineupUpdateScNotify> _parser = new MessageParser<HeliobusLineupUpdateScNotify>(() => new HeliobusLineupUpdateScNotify());

		// Token: 0x0400268A RID: 9866
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400268B RID: 9867
		public const int LineupFieldNumber = 8;

		// Token: 0x0400268C RID: 9868
		private HeliobusChallengeLineup lineup_;
	}
}
