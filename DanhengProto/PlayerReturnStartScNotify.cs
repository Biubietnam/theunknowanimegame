using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CDB RID: 3291
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnStartScNotify : IMessage<PlayerReturnStartScNotify>, IMessage, IEquatable<PlayerReturnStartScNotify>, IDeepCloneable<PlayerReturnStartScNotify>, IBufferMessage
	{
		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x060092CE RID: 37582 RVA: 0x00185588 File Offset: 0x00183788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnStartScNotify> Parser
		{
			get
			{
				return PlayerReturnStartScNotify._parser;
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x060092CF RID: 37583 RVA: 0x0018558F File Offset: 0x0018378F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnStartScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x060092D0 RID: 37584 RVA: 0x001855A1 File Offset: 0x001837A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnStartScNotify.Descriptor;
			}
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x001855A8 File Offset: 0x001837A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnStartScNotify()
		{
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x001855B0 File Offset: 0x001837B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnStartScNotify(PlayerReturnStartScNotify other) : this()
		{
			this.fGJCODEGEEG_ = other.fGJCODEGEEG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x001855D5 File Offset: 0x001837D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnStartScNotify Clone()
		{
			return new PlayerReturnStartScNotify(this);
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x001855DD File Offset: 0x001837DD
		// (set) Token: 0x060092D5 RID: 37589 RVA: 0x001855E5 File Offset: 0x001837E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FGJCODEGEEG
		{
			get
			{
				return this.fGJCODEGEEG_;
			}
			set
			{
				this.fGJCODEGEEG_ = value;
			}
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x001855EE File Offset: 0x001837EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnStartScNotify);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x001855FC File Offset: 0x001837FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnStartScNotify other)
		{
			return other != null && (other == this || (this.FGJCODEGEEG == other.FGJCODEGEEG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x0018562C File Offset: 0x0018382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FGJCODEGEEG != 0U)
			{
				num ^= this.FGJCODEGEEG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x0018566B File Offset: 0x0018386B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x00185673 File Offset: 0x00183873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x0018567C File Offset: 0x0018387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FGJCODEGEEG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FGJCODEGEEG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x001856B0 File Offset: 0x001838B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FGJCODEGEEG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FGJCODEGEEG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x001856EE File Offset: 0x001838EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnStartScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FGJCODEGEEG != 0U)
			{
				this.FGJCODEGEEG = other.FGJCODEGEEG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x0018571F File Offset: 0x0018391F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x00185728 File Offset: 0x00183928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FGJCODEGEEG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040038A4 RID: 14500
		private static readonly MessageParser<PlayerReturnStartScNotify> _parser = new MessageParser<PlayerReturnStartScNotify>(() => new PlayerReturnStartScNotify());

		// Token: 0x040038A5 RID: 14501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038A6 RID: 14502
		public const int FGJCODEGEEGFieldNumber = 2;

		// Token: 0x040038A7 RID: 14503
		private uint fGJCODEGEEG_;
	}
}
