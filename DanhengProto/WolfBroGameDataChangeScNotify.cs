using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001425 RID: 5157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameDataChangeScNotify : IMessage<WolfBroGameDataChangeScNotify>, IMessage, IEquatable<WolfBroGameDataChangeScNotify>, IDeepCloneable<WolfBroGameDataChangeScNotify>, IBufferMessage
	{
		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x0600E616 RID: 58902 RVA: 0x00263A9D File Offset: 0x00261C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameDataChangeScNotify> Parser
		{
			get
			{
				return WolfBroGameDataChangeScNotify._parser;
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x0600E617 RID: 58903 RVA: 0x00263AA4 File Offset: 0x00261CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameDataChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x0600E618 RID: 58904 RVA: 0x00263AB6 File Offset: 0x00261CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameDataChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600E619 RID: 58905 RVA: 0x00263ABD File Offset: 0x00261CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameDataChangeScNotify()
		{
		}

		// Token: 0x0600E61A RID: 58906 RVA: 0x00263AC5 File Offset: 0x00261CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameDataChangeScNotify(WolfBroGameDataChangeScNotify other) : this()
		{
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E61B RID: 58907 RVA: 0x00263AFA File Offset: 0x00261CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameDataChangeScNotify Clone()
		{
			return new WolfBroGameDataChangeScNotify(this);
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x0600E61C RID: 58908 RVA: 0x00263B02 File Offset: 0x00261D02
		// (set) Token: 0x0600E61D RID: 58909 RVA: 0x00263B0A File Offset: 0x00261D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x0600E61E RID: 58910 RVA: 0x00263B13 File Offset: 0x00261D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameDataChangeScNotify);
		}

		// Token: 0x0600E61F RID: 58911 RVA: 0x00263B21 File Offset: 0x00261D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameDataChangeScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.WolfBroGameData, other.WolfBroGameData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E620 RID: 58912 RVA: 0x00263B54 File Offset: 0x00261D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E621 RID: 58913 RVA: 0x00263B90 File Offset: 0x00261D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E622 RID: 58914 RVA: 0x00263B98 File Offset: 0x00261D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E623 RID: 58915 RVA: 0x00263BA1 File Offset: 0x00261DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E624 RID: 58916 RVA: 0x00263BD4 File Offset: 0x00261DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E625 RID: 58917 RVA: 0x00263C14 File Offset: 0x00261E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameDataChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E626 RID: 58918 RVA: 0x00263C68 File Offset: 0x00261E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x00263C74 File Offset: 0x00261E74
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
					if (this.wolfBroGameData_ == null)
					{
						this.WolfBroGameData = new WolfBroGameData();
					}
					input.ReadMessage(this.WolfBroGameData);
				}
			}
		}

		// Token: 0x04005B5A RID: 23386
		private static readonly MessageParser<WolfBroGameDataChangeScNotify> _parser = new MessageParser<WolfBroGameDataChangeScNotify>(() => new WolfBroGameDataChangeScNotify());

		// Token: 0x04005B5B RID: 23387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B5C RID: 23388
		public const int WolfBroGameDataFieldNumber = 2;

		// Token: 0x04005B5D RID: 23389
		private WolfBroGameData wolfBroGameData_;
	}
}
