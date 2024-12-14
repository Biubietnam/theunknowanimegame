using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F25 RID: 3877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicStoryInfoUpdateScNotify : IMessage<RogueMagicStoryInfoUpdateScNotify>, IMessage, IEquatable<RogueMagicStoryInfoUpdateScNotify>, IDeepCloneable<RogueMagicStoryInfoUpdateScNotify>, IBufferMessage
	{
		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x001D17C1 File Offset: 0x001CF9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicStoryInfoUpdateScNotify> Parser
		{
			get
			{
				return RogueMagicStoryInfoUpdateScNotify._parser;
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600ACFE RID: 44286 RVA: 0x001D17C8 File Offset: 0x001CF9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicStoryInfoUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600ACFF RID: 44287 RVA: 0x001D17DA File Offset: 0x001CF9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicStoryInfoUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x001D17E1 File Offset: 0x001CF9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfoUpdateScNotify()
		{
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x001D17E9 File Offset: 0x001CF9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfoUpdateScNotify(RogueMagicStoryInfoUpdateScNotify other) : this()
		{
			this.gIAKKPMFJHM_ = other.gIAKKPMFJHM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD02 RID: 44290 RVA: 0x001D180E File Offset: 0x001CFA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfoUpdateScNotify Clone()
		{
			return new RogueMagicStoryInfoUpdateScNotify(this);
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600AD03 RID: 44291 RVA: 0x001D1816 File Offset: 0x001CFA16
		// (set) Token: 0x0600AD04 RID: 44292 RVA: 0x001D181E File Offset: 0x001CFA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GIAKKPMFJHM
		{
			get
			{
				return this.gIAKKPMFJHM_;
			}
			set
			{
				this.gIAKKPMFJHM_ = value;
			}
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x001D1827 File Offset: 0x001CFA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicStoryInfoUpdateScNotify);
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x001D1835 File Offset: 0x001CFA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicStoryInfoUpdateScNotify other)
		{
			return other != null && (other == this || (this.GIAKKPMFJHM == other.GIAKKPMFJHM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x001D1864 File Offset: 0x001CFA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GIAKKPMFJHM != 0U)
			{
				num ^= this.GIAKKPMFJHM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x001D18A3 File Offset: 0x001CFAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x001D18AB File Offset: 0x001CFAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x001D18B4 File Offset: 0x001CFAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GIAKKPMFJHM != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GIAKKPMFJHM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x001D18E8 File Offset: 0x001CFAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GIAKKPMFJHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GIAKKPMFJHM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x001D1926 File Offset: 0x001CFB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicStoryInfoUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GIAKKPMFJHM != 0U)
			{
				this.GIAKKPMFJHM = other.GIAKKPMFJHM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x001D1957 File Offset: 0x001CFB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x001D1960 File Offset: 0x001CFB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GIAKKPMFJHM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400467D RID: 18045
		private static readonly MessageParser<RogueMagicStoryInfoUpdateScNotify> _parser = new MessageParser<RogueMagicStoryInfoUpdateScNotify>(() => new RogueMagicStoryInfoUpdateScNotify());

		// Token: 0x0400467E RID: 18046
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400467F RID: 18047
		public const int GIAKKPMFJHMFieldNumber = 14;

		// Token: 0x04004680 RID: 18048
		private uint gIAKKPMFJHM_;
	}
}
