using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001281 RID: 4737
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueAreaUnlockScNotify : IMessage<SyncRogueAreaUnlockScNotify>, IMessage, IEquatable<SyncRogueAreaUnlockScNotify>, IDeepCloneable<SyncRogueAreaUnlockScNotify>, IBufferMessage
	{
		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600D358 RID: 54104 RVA: 0x00234770 File Offset: 0x00232970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueAreaUnlockScNotify> Parser
		{
			get
			{
				return SyncRogueAreaUnlockScNotify._parser;
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600D359 RID: 54105 RVA: 0x00234777 File Offset: 0x00232977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueAreaUnlockScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600D35A RID: 54106 RVA: 0x00234789 File Offset: 0x00232989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueAreaUnlockScNotify.Descriptor;
			}
		}

		// Token: 0x0600D35B RID: 54107 RVA: 0x00234790 File Offset: 0x00232990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAreaUnlockScNotify()
		{
		}

		// Token: 0x0600D35C RID: 54108 RVA: 0x00234798 File Offset: 0x00232998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAreaUnlockScNotify(SyncRogueAreaUnlockScNotify other) : this()
		{
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x002347BD File Offset: 0x002329BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAreaUnlockScNotify Clone()
		{
			return new SyncRogueAreaUnlockScNotify(this);
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600D35E RID: 54110 RVA: 0x002347C5 File Offset: 0x002329C5
		// (set) Token: 0x0600D35F RID: 54111 RVA: 0x002347CD File Offset: 0x002329CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x0600D360 RID: 54112 RVA: 0x002347D6 File Offset: 0x002329D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueAreaUnlockScNotify);
		}

		// Token: 0x0600D361 RID: 54113 RVA: 0x002347E4 File Offset: 0x002329E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueAreaUnlockScNotify other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D362 RID: 54114 RVA: 0x00234814 File Offset: 0x00232A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D363 RID: 54115 RVA: 0x00234853 File Offset: 0x00232A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D364 RID: 54116 RVA: 0x0023485B File Offset: 0x00232A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D365 RID: 54117 RVA: 0x00234864 File Offset: 0x00232A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D366 RID: 54118 RVA: 0x00234898 File Offset: 0x00232A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D367 RID: 54119 RVA: 0x002348D6 File Offset: 0x00232AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueAreaUnlockScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D368 RID: 54120 RVA: 0x00234907 File Offset: 0x00232B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D369 RID: 54121 RVA: 0x00234910 File Offset: 0x00232B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040054A0 RID: 21664
		private static readonly MessageParser<SyncRogueAreaUnlockScNotify> _parser = new MessageParser<SyncRogueAreaUnlockScNotify>(() => new SyncRogueAreaUnlockScNotify());

		// Token: 0x040054A1 RID: 21665
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054A2 RID: 21666
		public const int AreaIdFieldNumber = 11;

		// Token: 0x040054A3 RID: 21667
		private uint areaId_;
	}
}
