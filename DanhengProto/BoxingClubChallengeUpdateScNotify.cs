using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200013D RID: 317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BoxingClubChallengeUpdateScNotify : IMessage<BoxingClubChallengeUpdateScNotify>, IMessage, IEquatable<BoxingClubChallengeUpdateScNotify>, IDeepCloneable<BoxingClubChallengeUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x0002A519 File Offset: 0x00028719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoxingClubChallengeUpdateScNotify> Parser
		{
			get
			{
				return BoxingClubChallengeUpdateScNotify._parser;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0002A520 File Offset: 0x00028720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BoxingClubChallengeUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0002A532 File Offset: 0x00028732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoxingClubChallengeUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0002A539 File Offset: 0x00028739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoxingClubChallengeUpdateScNotify()
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0002A541 File Offset: 0x00028741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoxingClubChallengeUpdateScNotify(BoxingClubChallengeUpdateScNotify other) : this()
		{
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0002A576 File Offset: 0x00028776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoxingClubChallengeUpdateScNotify Clone()
		{
			return new BoxingClubChallengeUpdateScNotify(this);
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x0002A57E File Offset: 0x0002877E
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x0002A586 File Offset: 0x00028786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH Challenge
		{
			get
			{
				return this.challenge_;
			}
			set
			{
				this.challenge_ = value;
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0002A58F File Offset: 0x0002878F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoxingClubChallengeUpdateScNotify);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0002A59D File Offset: 0x0002879D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoxingClubChallengeUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Challenge, other.Challenge) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0002A5D0 File Offset: 0x000287D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.challenge_ != null)
			{
				num ^= this.Challenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0002A60C File Offset: 0x0002880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0002A614 File Offset: 0x00028814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0002A61D File Offset: 0x0002881D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challenge_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0002A650 File Offset: 0x00028850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.challenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0002A690 File Offset: 0x00028890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoxingClubChallengeUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.challenge_ != null)
			{
				if (this.challenge_ == null)
				{
					this.Challenge = new LJLLHIJKKOH();
				}
				this.Challenge.MergeFrom(other.Challenge);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0002A6E4 File Offset: 0x000288E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0002A6F0 File Offset: 0x000288F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.challenge_ == null)
					{
						this.Challenge = new LJLLHIJKKOH();
					}
					input.ReadMessage(this.Challenge);
				}
			}
		}

		// Token: 0x04000625 RID: 1573
		private static readonly MessageParser<BoxingClubChallengeUpdateScNotify> _parser = new MessageParser<BoxingClubChallengeUpdateScNotify>(() => new BoxingClubChallengeUpdateScNotify());

		// Token: 0x04000626 RID: 1574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000627 RID: 1575
		public const int ChallengeFieldNumber = 6;

		// Token: 0x04000628 RID: 1576
		private LJLLHIJKKOH challenge_;
	}
}
