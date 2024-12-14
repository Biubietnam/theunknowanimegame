using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E9 RID: 4585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StoryLineTrialAvatarChangeScNotify : IMessage<StoryLineTrialAvatarChangeScNotify>, IMessage, IEquatable<StoryLineTrialAvatarChangeScNotify>, IDeepCloneable<StoryLineTrialAvatarChangeScNotify>, IBufferMessage
	{
		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600CCE1 RID: 52449 RVA: 0x00225D99 File Offset: 0x00223F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StoryLineTrialAvatarChangeScNotify> Parser
		{
			get
			{
				return StoryLineTrialAvatarChangeScNotify._parser;
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600CCE2 RID: 52450 RVA: 0x00225DA0 File Offset: 0x00223FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoryLineTrialAvatarChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600CCE3 RID: 52451 RVA: 0x00225DB2 File Offset: 0x00223FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryLineTrialAvatarChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x00225DB9 File Offset: 0x00223FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StoryLineTrialAvatarChangeScNotify()
		{
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x00225DD7 File Offset: 0x00223FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StoryLineTrialAvatarChangeScNotify(StoryLineTrialAvatarChangeScNotify other) : this()
		{
			this.bEHJDJBCJGO_ = other.bEHJDJBCJGO_.Clone();
			this.dGOCPFHCLLK_ = other.dGOCPFHCLLK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x00225E12 File Offset: 0x00224012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StoryLineTrialAvatarChangeScNotify Clone()
		{
			return new StoryLineTrialAvatarChangeScNotify(this);
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600CCE7 RID: 52455 RVA: 0x00225E1A File Offset: 0x0022401A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BEHJDJBCJGO
		{
			get
			{
				return this.bEHJDJBCJGO_;
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600CCE8 RID: 52456 RVA: 0x00225E22 File Offset: 0x00224022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DGOCPFHCLLK
		{
			get
			{
				return this.dGOCPFHCLLK_;
			}
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x00225E2A File Offset: 0x0022402A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryLineTrialAvatarChangeScNotify);
		}

		// Token: 0x0600CCEA RID: 52458 RVA: 0x00225E38 File Offset: 0x00224038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StoryLineTrialAvatarChangeScNotify other)
		{
			return other != null && (other == this || (this.bEHJDJBCJGO_.Equals(other.bEHJDJBCJGO_) && this.dGOCPFHCLLK_.Equals(other.dGOCPFHCLLK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCEB RID: 52459 RVA: 0x00225E8C File Offset: 0x0022408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bEHJDJBCJGO_.GetHashCode();
			num ^= this.dGOCPFHCLLK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x00225ECE File Offset: 0x002240CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x00225ED6 File Offset: 0x002240D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x00225EDF File Offset: 0x002240DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dGOCPFHCLLK_.WriteTo(ref output, StoryLineTrialAvatarChangeScNotify._repeated_dGOCPFHCLLK_codec);
			this.bEHJDJBCJGO_.WriteTo(ref output, StoryLineTrialAvatarChangeScNotify._repeated_bEHJDJBCJGO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x00225F18 File Offset: 0x00224118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bEHJDJBCJGO_.CalculateSize(StoryLineTrialAvatarChangeScNotify._repeated_bEHJDJBCJGO_codec);
			num += this.dGOCPFHCLLK_.CalculateSize(StoryLineTrialAvatarChangeScNotify._repeated_dGOCPFHCLLK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x00225F64 File Offset: 0x00224164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StoryLineTrialAvatarChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bEHJDJBCJGO_.Add(other.bEHJDJBCJGO_);
			this.dGOCPFHCLLK_.Add(other.dGOCPFHCLLK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x00225FA3 File Offset: 0x002241A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x00225FAC File Offset: 0x002241AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.dGOCPFHCLLK_.AddEntriesFrom(ref input, StoryLineTrialAvatarChangeScNotify._repeated_dGOCPFHCLLK_codec);
						continue;
					}
				}
				else if (num == 32U || num == 34U)
				{
					this.bEHJDJBCJGO_.AddEntriesFrom(ref input, StoryLineTrialAvatarChangeScNotify._repeated_bEHJDJBCJGO_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400529D RID: 21149
		private static readonly MessageParser<StoryLineTrialAvatarChangeScNotify> _parser = new MessageParser<StoryLineTrialAvatarChangeScNotify>(() => new StoryLineTrialAvatarChangeScNotify());

		// Token: 0x0400529E RID: 21150
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400529F RID: 21151
		public const int BEHJDJBCJGOFieldNumber = 4;

		// Token: 0x040052A0 RID: 21152
		private static readonly FieldCodec<uint> _repeated_bEHJDJBCJGO_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040052A1 RID: 21153
		private readonly RepeatedField<uint> bEHJDJBCJGO_ = new RepeatedField<uint>();

		// Token: 0x040052A2 RID: 21154
		public const int DGOCPFHCLLKFieldNumber = 3;

		// Token: 0x040052A3 RID: 21155
		private static readonly FieldCodec<uint> _repeated_dGOCPFHCLLK_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x040052A4 RID: 21156
		private readonly RepeatedField<uint> dGOCPFHCLLK_ = new RepeatedField<uint>();
	}
}
