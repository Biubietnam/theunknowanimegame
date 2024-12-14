using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C5 RID: 4293
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAetherDivideLineUpCsReq : IMessage<SetAetherDivideLineUpCsReq>, IMessage, IEquatable<SetAetherDivideLineUpCsReq>, IDeepCloneable<SetAetherDivideLineUpCsReq>, IBufferMessage
	{
		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600BF6F RID: 49007 RVA: 0x00203769 File Offset: 0x00201969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAetherDivideLineUpCsReq> Parser
		{
			get
			{
				return SetAetherDivideLineUpCsReq._parser;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600BF70 RID: 49008 RVA: 0x00203770 File Offset: 0x00201970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAetherDivideLineUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600BF71 RID: 49009 RVA: 0x00203782 File Offset: 0x00201982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAetherDivideLineUpCsReq.Descriptor;
			}
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x00203789 File Offset: 0x00201989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAetherDivideLineUpCsReq()
		{
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x00203791 File Offset: 0x00201991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAetherDivideLineUpCsReq(SetAetherDivideLineUpCsReq other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF74 RID: 49012 RVA: 0x002037C6 File Offset: 0x002019C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAetherDivideLineUpCsReq Clone()
		{
			return new SetAetherDivideLineUpCsReq(this);
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600BF75 RID: 49013 RVA: 0x002037CE File Offset: 0x002019CE
		// (set) Token: 0x0600BF76 RID: 49014 RVA: 0x002037D6 File Offset: 0x002019D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupInfo Lineup
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

		// Token: 0x0600BF77 RID: 49015 RVA: 0x002037DF File Offset: 0x002019DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAetherDivideLineUpCsReq);
		}

		// Token: 0x0600BF78 RID: 49016 RVA: 0x002037ED File Offset: 0x002019ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAetherDivideLineUpCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF79 RID: 49017 RVA: 0x00203820 File Offset: 0x00201A20
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

		// Token: 0x0600BF7A RID: 49018 RVA: 0x0020385C File Offset: 0x00201A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x00203864 File Offset: 0x00201A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x0020386D File Offset: 0x00201A6D
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

		// Token: 0x0600BF7D RID: 49021 RVA: 0x002038A0 File Offset: 0x00201AA0
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

		// Token: 0x0600BF7E RID: 49022 RVA: 0x002038E0 File Offset: 0x00201AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAetherDivideLineUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new AetherDivideLineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF7F RID: 49023 RVA: 0x00203934 File Offset: 0x00201B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x00203940 File Offset: 0x00201B40
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
						this.Lineup = new AetherDivideLineupInfo();
					}
					input.ReadMessage(this.Lineup);
				}
			}
		}

		// Token: 0x04004DB8 RID: 19896
		private static readonly MessageParser<SetAetherDivideLineUpCsReq> _parser = new MessageParser<SetAetherDivideLineUpCsReq>(() => new SetAetherDivideLineUpCsReq());

		// Token: 0x04004DB9 RID: 19897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DBA RID: 19898
		public const int LineupFieldNumber = 8;

		// Token: 0x04004DBB RID: 19899
		private AetherDivideLineupInfo lineup_;
	}
}
